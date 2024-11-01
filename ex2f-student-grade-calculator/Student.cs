namespace ex2f_student_grade_calculator
{
    public class Student
    {
        public string Name { get; set; }
        public List<int> Grades { get; set; } 
        public double AverageGrade 
        { 
            get { return Grades.Average(); }
                }
        public string LetterGrade 
        { 
            get
            {
                return GradingService.EvaluateGrade(AverageGrade);
            }
        }
    }
}
