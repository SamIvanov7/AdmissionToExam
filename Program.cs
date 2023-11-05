using System;

namespace AdmissionToExam
{
    class Program
    {
        static void Main(string[] args)
        {
            double sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Enter grade " + (i + 1) + ": ");
                double grade = double.Parse(Console.ReadLine());
                sum += grade;
            }

            double average = sum / 5;
            Console.WriteLine("Average grade: " + average);

            if (average >= 4)
            {
                Console.WriteLine("The student is admitted to the exam.");
            }
            else
            {
                Console.WriteLine("The student is not admitted to the exam.");
            }
        }
    }
}
