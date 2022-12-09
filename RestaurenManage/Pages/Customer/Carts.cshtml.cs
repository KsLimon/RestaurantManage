using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurenManage.Model;
using System.Diagnostics;

namespace RestaurenManage.Pages.Customer
{
    public class CartsModel : PageModel
    {
        private readonly RestaurenManage.Data.RmanageContext _context;

        public CartsModel(RestaurenManage.Data.RmanageContext context)
        {
            _context = context;
        }
		[BindProperty]
		public IList<CartModel> CartModel { get; set; } = default!;

        public async Task OnGetAsync()
		{
			if (_context.FoodModel != null)
			{
				CartModel = await _context.CartModel.ToListAsync();
			}
		}
	}
}
