using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Globalization;

namespace ex3b_student_web_app.Pages
{
    public class PrivacyModel : PageModel
    {
        public void OnGet()
        {
            string dateTime = DateTime.Now.ToString("d", new CultureInfo("en-US"));
            ViewData["TimeStamp"] = dateTime;
        }
    }

}
