using System;
namespace TSIMSServer.Model
{
	/// <summary>
	/// t_book_distribution:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class t_book_distribution
	{
		public t_book_distribution()
		{}
		#region Model
		private int _id;
		private string _unit_num;
		private int _unit_type=0;
		private string _book_num;
		private int _count=0;
		private decimal _total_fee=0.00M;
		private decimal _paid_fee=0.00M;
		private string _user_num;
		private DateTime? _receive_date;
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
		public string unit_num
		{
			set{ _unit_num=value;}
			get{return _unit_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int unit_type
		{
			set{ _unit_type=value;}
			get{return _unit_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string book_num
		{
			set{ _book_num=value;}
			get{return _book_num;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int count
		{
			set{ _count=value;}
			get{return _count;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal total_fee
		{
			set{ _total_fee=value;}
			get{return _total_fee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public decimal paid_fee
		{
			set{ _paid_fee=value;}
			get{return _paid_fee;}
		}
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
		public DateTime? receive_date
		{
			set{ _receive_date=value;}
			get{return _receive_date;}
		}
		#endregion Model

	}
}

