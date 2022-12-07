using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
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
		public void onGetFood_Id(int? id)
		{
			Debug.WriteLine("*************************************************************");
			Debug.WriteLine(id);
		}
	}
}
