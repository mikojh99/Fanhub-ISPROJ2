using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Fanhub.Areas.Identity.Pages.Account
{
    public class SignupModel : PageModel
    {
        public void OnGet()
        {
        }
        public string ReturnUrl { get; set; }
    }
}
