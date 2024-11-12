using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ex3b_student_web_app.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public DateTime BirthDate { get; set; }

        public DateTime TodayDate { get; set; }
        public int Age { get; set; }

        public void OnGet()
        {
            TodayDate = DateTime.Today;
        }

        public void OnPost() 
        {
            TodayDate = DateTime.Today;

            Age = TodayDate.Year - BirthDate.Year;
        }
    }
}
