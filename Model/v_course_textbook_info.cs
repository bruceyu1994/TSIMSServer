/**  版本信息模板在安装目录下，可自行修改。
* v_course_textbook_info.cs
*
* 功 能： N/A
* 类 名： v_course_textbook_info
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/9/19 9:25:43   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// v_course_textbook_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class v_course_textbook_info
	{
		public v_course_textbook_info()
		{}
		#region Model
		private string _course_name;
		private int? _need_book=1;
		private string _isbn;
		private string _book_name;
		private decimal? _price;
		private string _user_num;
		/// <summary>
		/// 
		/// </summary>
		public string course_name
		{
			set{ _course_name=value;}
			get{return _course_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? need_book
		{
			set{ _need_book=value;}
			get{return _need_book;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string isbn
		{
			set{ _isbn=value;}
			get{return _isbn;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string book_name
		{
			set{ _book_name=value;}
			get{return _book_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal? price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_num
		{
			set{ _user_num=value;}
			get{return _user_num;}
		}
		#endregion Model

	}
}

