using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSIMSServer.Model
{
    public class BookOrderInfo
    {
        public BookOrderInfo()
        { }
        #region Model
        private string _user_num;
        private List<TextBookInfo> _textBookInfoList;

        /// <summary>
        /// 
        /// </summary>
        public string user_num
        {
            set { _user_num = value; }
            get { return _user_num; }
        }

        /// <summary>
        /// 
        /// </summary>
        public List<TextBookInfo> textBookInfoList
        {
            set { _textBookInfoList = value; }
            get { return _textBookInfoList; }
        }

        #endregion Model
    }
}
