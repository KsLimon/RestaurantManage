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
		public IList<TableModel> TableModel { get; set; }

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
		public List<TableModel> Tables { get; set; }

		//For Uploding from Background
		public CartModel CartList = new CartModel();

		public async Task<IActionResult> OnGetFoodId(Dictionary<string, string> data)
		{
			Food = _context.FoodModel.Where(c => c.FoodName.Equals(data["key1"])).ToList();
			Tables = _context.TableModel.Where(c => c.TabName.Equals(HttpContext.Session.GetString("TableName"))).ToList();

			Debug.WriteLine(Food[0].FoodName);
			Debug.WriteLine(HttpContext.Session.GetString("TableName"));

			if (!ModelState.IsValid)
			{
				return Page();
			}


			CartList.TableName = HttpContext.Session.GetString("TableName");
			CartList.Tablepos = Tables[0].Position;
			CartList.foodname = Food[0].FoodName;
			CartList.foodprice = Food[0].Price;
			CartList.person = 1;

			_context.CartModel.Add(CartList);
			await _context.SaveChangesAsync();

			return RedirectToPage("/Customer/Foods");
		}

	}
}
