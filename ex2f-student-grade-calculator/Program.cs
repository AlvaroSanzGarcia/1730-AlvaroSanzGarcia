namespace ex2f_student_grade_calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Student Grade Evaluator!");
            Student student = new Student();

            Console.WriteLine("Enter student's name: ");
            student.Name = Console.ReadLine();

            string input;
            student.Grades = new List<int>();

            while (true)
            {
                Console.WriteLine("Enter a grade (or type 'done' to finish): ");
                input = Console.ReadLine();

                if (input.ToLower() == "done") break;

                if (int.TryParse(input, out int grade))
                {
                    student.Grades.Add(grade);
                }

                else
                {
                    Console.WriteLine("Invalid grade. Please enter a numeric value.");
                }

            }

            Console.WriteLine($"{student.Name}: Average Grade = {student.AverageGrade}, Letter Grade = {student.LetterGrade}");
        }
    }
}
