using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Diagnostics;

namespace RestaurenManage.Pages.AdminPage
{
    public class SigninModel : PageModel
    {
        private readonly RestaurenManage.Data.RmanageContext _context;

        public SigninModel(RestaurenManage.Data.RmanageContext context)
        {
            _context = context;
        }

        [BindProperty]
        public RestaurenManage.Model.LoginModel LoginModel { get; set; }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var valID = Request.Form["valID"];


            if (valID == "654321")
            {
                Debug.WriteLine(valID);
                _context.LoginModel.Add(LoginModel);
                await _context.SaveChangesAsync();

                return RedirectToPage("/AdminPage/Login");
            }

            return RedirectToPage("/AdminPage/Signin");
        }
    }
}
