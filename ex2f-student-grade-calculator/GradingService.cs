﻿namespace ex2f_student_grade_calculator
{
    public class GradingService
    {

        public static string EvaluateGrade (double average)
        {
            if (average >= 90)
                return "A";            
            else if (average >= 80)            
                return "B";            
            else if (average >= 70)            
                return "C";            
            else if (average >= 60)            
                return "D";            
            else            
                return "F";
            

        }
    }
}
