using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_book_order:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_book_order
	{
		public t_book_order()
		{}
		#region Model
		private int _id;
		private string _isbn;
		private string _user_num;
		/// <summary>
		/// auto_increment
		/// </summary>
		public int id
		{
			set{ _id=value;}
			get{return _id;}
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
		public string user_num
		{
			set{ _user_num=value;}
			get{return _user_num;}
		}
		#endregion Model

	}
}

