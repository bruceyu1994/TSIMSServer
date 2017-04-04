using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_teaching:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_teaching
	{
		public t_teaching()
		{}
		#region Model
		private int _id;
		private string _semester;
		private string _course_num;
		private string _course_name;
		private int _course_type=1;
		private int? _need_book=1;
		private string _college_num;
		private string _department_num;
		private string _major_num;
		private string _class_num;
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
		public string college_num
		{
			set{ _college_num=value;}
			get{return _college_num;}
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
		public string major_num
		{
			set{ _major_num=value;}
			get{return _major_num;}
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
		public string user_num
		{
			set{ _user_num=value;}
			get{return _user_num;}
		}
		#endregion Model

	}
}

