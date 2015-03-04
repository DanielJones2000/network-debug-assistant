using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace network_debug_assistant
{
    class SocketServer
    {
        static Socket newsock = null;

        /// <summary>
        /// 创建TCP socket通讯服务端
        /// </summary>
        /// <param name="ip"></param>
        /// <param name="host"></param>
        public static Socket createServer(String ip, int host) 
        {
            try
            {
                IPEndPoint ipep = new IPEndPoint(IPAddress.Parse(ip), host);//本机预使用的IP和端口
                newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                newsock.Bind(ipep);//绑定
                newsock.Listen(10);//监听
                return newsock;
            }
            catch (SocketException e) 
            {
                throw e;
            }
        }
    }
}
