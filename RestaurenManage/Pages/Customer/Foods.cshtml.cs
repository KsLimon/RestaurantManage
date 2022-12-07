using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurenManage.Model;
using System.Diagnostics;
using Microsoft.AspNetCore.Http;

namespace RestaurenManage.Pages.Customer
{
    public class FoodsModel : PageModel
    {
		private readonly RestaurenManage.Data.RmanageContext _context;

		public FoodsModel(RestaurenManage.Data.RmanageContext context)
		{
			_context = context;
		}
		[BindProperty]
		public IList<FoodModel> FoodModel { get; set; } 

		[BindProperty]
		public CartModel Carts { get; set; }

		public async Task  OnGetAsync(string? tm)
		{
			if(tm != null)
			{
				HttpContext.Session.SetString("TableName", tm);
			}

			if (_context.FoodModel != null)
			{
				FoodModel = await _context.FoodModel.ToListAsync();
			}
		}

		public List<FoodModel> Food { get; set; }

		public async Task<IActionResult> OnGetFoodId(Dictionary<string, string> data)
		{
			Food = _context.FoodModel.Where(c => c.FoodName.Equals(data["key1"])).ToList();
			Debug.WriteLine("*************************************************************");

			Debug.WriteLine(Food[0].FoodName);
			Debug.WriteLine(HttpContext.Session.GetString("TableName"));

			if (!ModelState.IsValid)
			{
				return Page();
			}
			//_context.CartModel.Add(Carts);
			//await _context.SaveChangesAsync();

			return RedirectToPage("/Customer/Foods");
		}

		//public void Tablename(string? tm)
		//{
		//	TableName = tm;
		//	Debug.WriteLine(tm);
		//	Debug.WriteLine(TableName);
		//}
	}
}
