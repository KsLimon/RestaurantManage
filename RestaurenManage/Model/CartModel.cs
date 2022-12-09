using System.ComponentModel.DataAnnotations;

namespace RestaurenManage.Model
{
	public class CartModel
	{
		[Key]
		public int Id { get; set; }
		public string TableName { get; set; }
		public string? Tablepos { get; set; }
		public string foodname { get; set; }
		public int foodprice { get; set;}
		public int person { get; set; }
	}
}
