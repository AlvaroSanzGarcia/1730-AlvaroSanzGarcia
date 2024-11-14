using ex3b_student_web_app.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ex3b_student_web_app.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        
        public Person Person { get; set; } = new Person();

        public DateTime TodayDate { get; set; }
        

        public void OnGet()
        {
            TodayDate = DateTime.Today;
        }

        public void OnPost() 
        {
            TodayDate = DateTime.Today;

        }
    }
}
