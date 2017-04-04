using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_book:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_book
	{
		public t_book()
		{}
		#region Model
		private string _isbn;
		private string _book_name;
		private string _author;
		private decimal? _price;
		private string _publisher;
		private string _edition;
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
		public string author
		{
			set{ _author=value;}
			get{return _author;}
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
		public string publisher
		{
			set{ _publisher=value;}
			get{return _publisher;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string edition
		{
			set{ _edition=value;}
			get{return _edition;}
		}
		#endregion Model

	}
}

