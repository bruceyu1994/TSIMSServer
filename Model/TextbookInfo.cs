using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSIMSServer.Model
{
    public class TextBookInfo
    {
        public TextBookInfo()
        { }

        private string _isbn;
        private int _isSelect;

        /// <summary>
        /// 
        /// </summary>
        public string isbn
        {
            set { _isbn = value; }
            get { return _isbn; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int isSelect
        {
            set { _isSelect = value; }
            get { return _isSelect; }
        }
    }
}
