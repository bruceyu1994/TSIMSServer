using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_user:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_user
	{
		public t_user()
		{}
		#region Model
		private string _user_num;
		private string _user_name;
		private string _password= "123456";
		private string _college_num;
		private string _department_num;
		private string _major_num;
		private string _class_num;
		private DateTime _enter_school_date= Convert.ToDateTime("1970-01-01");
		private string _phone;
		private int _identity=0;
		/// <summary>
		/// 
		/// </summary>
		public string user_num
		{
			set{ _user_num=value;}
			get{return _user_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string user_name
		{
			set{ _user_name=value;}
			get{return _user_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string password
		{
			set{ _password=value;}
			get{return _password;}
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
		public DateTime enter_school_date
		{
			set{ _enter_school_date=value;}
			get{return _enter_school_date;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int identity
		{
			set{ _identity=value;}
			get{return _identity;}
		}
		#endregion Model

	}
}

