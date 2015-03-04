using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Net.Sockets;
using System.IO;
using System.Net;

namespace network_debug_assistant
{
    public partial class Index : Form
    {
        Thread t;
        static Socket socektServer;
        static Socket socketClient;
        static String msgStr = null;
        int port;
        String ip;
        Encoding code;
        private delegate void writeToolMessage();
        private delegate void writeBackValueMessage();
        private delegate void writeBackValueMessage1();
        Boolean isNext = true;

        public Index()
        {
            InitializeComponent();
            _ip.Text = "127.0.0.1";
            _port.Text = "9090";
            _type.Items.AddRange(new object[] { new ComboBoxItem("TCP客户端", "tcp_client"), new ComboBoxItem("TCP服务端", "tcp_server") });
            _type.SelectedIndex = 0;
            _code.Items.AddRange(new object[] 
            { 
                new ComboBoxItem("UTF8", Encoding.UTF8), new ComboBoxItem("ASCII", Encoding.ASCII),
                new ComboBoxItem("Unicode", Encoding.Unicode), new ComboBoxItem("UTF32", Encoding.UTF32)
            });
            _code.SelectedIndex = 0;
        }

        private void _clearBackValues_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _backValues.Clear();
        }

        private void _clearSendValue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            _sendValue.Clear();
        }

        private void _connect_Click(object sender, EventArgs e)
        {
            try 
            {
                port = Int32.Parse(_port.Text.ToString());
            }
            catch (FormatException)
            {
                _connect.Text = "链接";
                _toolMessage.Text = "链接异常，请检查IP、端口";
            }
            ip = _ip.Text;
            ComboBoxItem codeItem = _code.SelectedItem as ComboBoxItem;
            code = codeItem.Value as Encoding;
            String text = _connect.Text;
            ComboBoxItem item = _type.SelectedItem as ComboBoxItem;
            String client = "tcp_client";
            String server = "tcp_server";
            if ("链接".Equals(text)) 
            {
                if (client.Equals(item.Value.ToString()))
                {
                    socketClient = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    t = new Thread(createClient);
                    t.IsBackground = true;
                    t.Start();
                }
                else if (server.Equals(item.Value.ToString()))
                {
                    t = new Thread(createServer);
                    t.IsBackground = true;
                    t.Start();
                }
                _connect.Text = "断开";
                _toolMessage.Text = "准备就绪";
                isNext = true;
            }
            else if ("断开".Equals(text)) 
            {
                if (t != null)
                    t.Abort();
                if (socektServer != null)
                   socektServer.Close();
                if (socketClient != null)
                {
                    socketClient.Close();
                    socketClient = null;
                }
                _connect.Text = "链接";
                isNext = false;
                _toolMessage.Text = "链接已经断开";
            }
        }

        private void createClient()
        {
            try
            {
                IPEndPoint ie = new IPEndPoint(IPAddress.Parse(ip), port);//服务器的IP和端口
                //因为客户端只是用来向特定的服务器发送信息，所以不需要绑定本机的IP和端口。不需要监听。
                socketClient.Connect(ie);
                byte[] data = new byte[1024];
                while (isNext)
                {
                    int recv = socketClient.Receive(data);
                    msgStr = Encoding.ASCII.GetString(data, 0, recv);
                    writeBackValueMessage1 w = new writeBackValueMessage1(writeMessage);
                    this.Invoke(w);
                }
            }
            catch (SocketException)
            {
                writeToolMessage wtmError1 = new writeToolMessage(delegateSocketServerError);
                this.BeginInvoke(wtmError1);
            }
        }

        /// <summary>
        /// 代理服务
        /// </summary>
        private void delegateSocketServerError()
        {
            _connect.Text = "链接";
            _toolMessage.Text = "链接异常，请检查IP、端口";
        }

        /// <summary>
        /// 代理服务
        /// </summary>
        private void writeMessage()
        {
            _backValues.AppendText(msgStr);
        }

        /// <summary>
        /// 创建TCP socket服务端
        /// </summary>
        private void createServer()
        {
            try
            {
                socektServer = SocketServer.createServer(ip, port);
                Thread.Sleep(1000);
                socketClient = socektServer.Accept();//当有可用的客户端连接尝试时执行，并返回一个新的socket,用于与客户端之间的通信
                int recv;//用于表示客户端发送的信息长度
                byte[] data = new byte[1024];//用于缓存客户端所发送的信息,通过socket传递的信息必须为字节数组
                while (isNext)
                {
                    //用死循环来不断的从客户端获取信息
                    recv = socketClient.Receive(data);
                    if (recv == 0)//当信息长度为0，说明客户端连接断开
                        break;
                    msgStr = code.GetString(data, 0, recv);
                    writeBackValueMessage wbvm = new writeBackValueMessage(writeMessage);
                    this.Invoke(wbvm);
                }
            }
            catch (IOException)
            {
                writeToolMessage wtmError1 = new writeToolMessage(delegateSocketServerError);
                this.BeginInvoke(wtmError1);
            }
            catch (FormatException)
            {
                writeToolMessage wtmError2 = new writeToolMessage(delegateSocketServerError);
                this.BeginInvoke(wtmError2);
            }
            catch (SocketException) 
            {
                if (socektServer != null)
                    socektServer.Close();
                if (socketClient != null)
                {
                    socketClient.Close();
                    socketClient = null;
                }
                writeToolMessage wtmError3 = new writeToolMessage(delegateSocketServerError);
                this.BeginInvoke(wtmError3);
            }
        }

        private void _mouseHover(object sender, EventArgs e) 
        {
            if (sender.Equals(_connect)) 
            {
                if (_connect.Text == "链接")
                    _toolMessage.Text = "链接已经断开"; 
                else
                    _toolMessage.Text = "准备就绪";
            }
            else if (sender.Equals(_clearBackValues)) 
            {
                _toolMessage.Text = "清空返回信息中的内容";
            }
            else if (sender.Equals(_send)) 
            {
                _toolMessage.Text = "发送信息";
            }
            else if (sender.Equals(_clearSendValue)) 
            {
                _toolMessage.Text = "清空发送信息中的内容";
            }
        }

        private void _send_Click(object sender, EventArgs e)
        {
            try
            {
                byte[] data = new byte[1024];
                data = code.GetBytes(_sendValue.Text);
                socketClient.Send(data, data.Length, SocketFlags.None);//发送信息
                _toolMessage.Text = "发送信息成功";
            }
            catch (Exception)
            {
                _toolMessage.Text = "发送信息失败";
            }
        }
    }
}
