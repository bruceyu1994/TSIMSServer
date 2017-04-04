using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_teaching_book:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_teaching_book
	{
		public t_teaching_book()
		{}
		#region Model
		private int _id;
		private int? _teaching_id;
		private string _isbn;
		private string _remark;
		private int? _book_status=1;
		private int? _dept_check=0;
		private int? _college_check=0;
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
		public int? teaching_id
		{
			set{ _teaching_id=value;}
			get{return _teaching_id;}
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
		public string remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? book_status
		{
			set{ _book_status=value;}
			get{return _book_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? dept_check
		{
			set{ _dept_check=value;}
			get{return _dept_check;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? college_check
		{
			set{ _college_check=value;}
			get{return _college_check;}
		}
		#endregion Model

	}
}

