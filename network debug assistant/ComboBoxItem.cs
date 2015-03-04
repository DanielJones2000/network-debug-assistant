using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace network_debug_assistant
{
    class ComboBoxItem
    {
        private string _text = null;
        private object _value = null;

        public string Text { get { return this._text; } set { this._text = value; } }
        public object Value { get { return this._value; } set { this._value = value; } }

        public ComboBoxItem(String text,Object value) 
        {
            this._text = text;
            this._value = value;
        }

        public override string ToString()
        {
            return this._text;
        }
    }
}
