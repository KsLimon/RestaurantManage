using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurenManage.Model;
using System.Diagnostics;

namespace RestaurenManage.Pages
{
    public class IndexModel : PageModel
    {
		private readonly RestaurenManage.Data.RmanageContext _context;

		public IndexModel(RestaurenManage.Data.RmanageContext context)
		{
			_context = context;
		}

		public IList<TableModel> TableModel { get; set; } = default!;

		public async Task OnGetAsync()
		{
			if (_context.TableModel != null)
			{
				TableModel = await _context.TableModel.ToListAsync();
			}
		}
		
	}
}