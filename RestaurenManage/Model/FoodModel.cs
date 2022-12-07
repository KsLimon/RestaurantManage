using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace RestaurenManage.Model
{
	public class FoodModel
	{
		[Key]
		public int Foodid { get; set; }
		[Required]
		public string FoodName { get; set; }
		public string? Foodimg { get; set; }
		[Required]
		public int Price { get; set; }
		public string? Couantity { get; set; }
		public bool? avail { get; set; }
	}
}
