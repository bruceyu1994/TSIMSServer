using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_class:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_class
	{
		public t_class()
		{}
		#region Model
		private string _class_num;
		private string _class_name;
		private string _major_num;
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
		public string major_num
		{
			set{ _major_num=value;}
			get{return _major_num;}
		}
		#endregion Model

	}
}

