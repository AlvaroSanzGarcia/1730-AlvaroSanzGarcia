namespace ex3b_student_web_app.Models
{
    public class Person
    {
        public string? Name { get; set; }
        public DateTime? BirthDate { get; set; }

        public int? Age 
        { 
            get 
            {
                if (BirthDate.HasValue)
                {
                    return DateTime.Today.Year - BirthDate.Value.Year;
                }
                return null;
            } 
        }
    }
}
