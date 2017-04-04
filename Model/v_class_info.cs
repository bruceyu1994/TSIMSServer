using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// v_class_info:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class v_class_info
	{
		public v_class_info()
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
		#endregion Model

	}
}

