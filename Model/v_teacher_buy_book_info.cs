using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// v_teacher_buy_book_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class v_teacher_buy_book_info
	{
		public v_teacher_buy_book_info()
		{}
		#region Model
		private string _college_num;
		private string _college_name;
		private string _department_num;
		private string _department_name;
		private string _major_num;
		private string _major_name;
		private string _class_num;
		private string _class_name;
		private string _semester;
		private string _course_num;
		private string _course_name;
		private int _course_type=1;
		private int? _need_book=1;
		private string _teacher_num;
		private string _teacher_name;
		private string _isbn;
		private string _book_name;
		private string _author;
		private decimal? _price;
		private string _publisher;
		private string _edition;
		private long _amount=0;
		/// <summary>
		/// 
		/// </summary>
		public string college_num
		{
			set{ _college_num=value;}
			get{return _college_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string college_name
		{
			set{ _college_name=value;}
			get{return _college_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string department_num
		{
			set{ _department_num=value;}
			get{return _department_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string department_name
		{
			set{ _department_name=value;}
			get{return _department_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string major_num
		{
			set{ _major_num=value;}
			get{return _major_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string major_name
		{
			set{ _major_name=value;}
			get{return _major_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string class_num
		{
			set{ _class_num=value;}
			get{return _class_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string class_name
		{
			set{ _class_name=value;}
			get{return _class_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string semester
		{
			set{ _semester=value;}
			get{return _semester;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string course_num
		{
			set{ _course_num=value;}
			get{return _course_num;}
		}
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
		public int course_type
		{
			set{ _course_type=value;}
			get{return _course_type;}
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
		public string teacher_num
		{
			set{ _teacher_num=value;}
			get{return _teacher_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string teacher_name
		{
			set{ _teacher_name=value;}
			get{return _teacher_name;}
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
		/// <summary>
		/// 
		/// </summary>
		public long amount
		{
			set{ _amount=value;}
			get{return _amount;}
		}
		#endregion Model

	}
}

