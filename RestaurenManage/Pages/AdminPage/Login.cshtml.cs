using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RestaurenManage.Model;
using System.Diagnostics;

namespace RestaurenManage.Pages.AdminPage
{
    public class LoginModelcs : PageModel
    {
        private readonly RestaurenManage.Data.RmanageContext _context;

        public LoginModelcs(RestaurenManage.Data.RmanageContext context)
        {
            _context = context;
        }

        

        public List<LoginModel> GetUserByid(string id)
        {
            return _context.LoginModel.Where(c => c.LoginID.Equals(id)).ToList();
        }
        //public dynamic GetpassByid(string pass)
        //{
        //    return _context.LoginModel.Where(c => c.Password.Equals(pass)).First();
        //}

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            var logid = Request.Form["LMLoginID"];
            var pass = Request.Form["LMPassword"];


            if(GetUserByid(logid)[0].Password == pass)
            {
                return RedirectToPage("/AdminPage/Admin");
            }

            return RedirectToPage("/AdminPage/Login");
        }


        
    }
}
