// See https://aka.ms/new-console-template for more information
using Module2Review___Student_Grades;
using System.IO;


internal class Program
{
    

    private static void Main(string[] args)
    {

        Console.WriteLine("MODULE 2 Review Project - Class Grades");
        Console.WriteLine();
       


        // 1. CREATE List of type 'Student'

        List<Student> students = new List<Student>();



        // 2. CREATE 4 instances (also called objects) of type Student

        Student stud1 = new Student()
        {
            Name = "Student Aa",
            ID = 12345,
            gradesList = { 98.2}
            
                //Will ask questions about these later:
                    //Student.Grades.Add(98.2),
                    //Student.gradesList.Add(98.2),
                    // gradesList = 98,
                    //gradesList.Add(98),
                    //gradesList.Add(new Student(98.2)),

                    //parts.Add(new Part() { PartName = "crank arm", PartId = 1234 });
        };


        Student stud2 = new Student()
        {
            Name = "Student Bb",
            ID = 22345,
            gradesList = { 63.8 }
            
        };

        Student stud3 = new Student()
        {
            Name = "Student Cc",
            ID = 32345,
            gradesList = new() { 89.3 }
           

        };

        Student stud4 = new Student()
        {
            Name = "Student Dd",
            ID = 42345,
            gradesList = new() { 79.9 }
            

        };


        // 3. POPULATE the List "students"

        students.Add(stud1);
        students.Add(stud2);
        students.Add(stud3);
        students.Add(stud4);

        

        // 4. ADD METHODS - created in the class to add grades to the list. Also uses Method Overloading technique

        stud1.AddGrade(94.3);
        stud1.AddGrade(90.0, 23.5, 89.4);

        stud2.AddGrade(99.3);
        stud2.AddGrade(70.0, 73.5, 83.4);

        stud3.AddGrade(89.1);
        stud3.AddGrade(20.0, 93.5, 77.4);

        stud4.AddGrade(86.0);
        stud4.AddGrade(80.0, 83.5, 93.4);


               
        // 5. LOOP THROUGH YOUR LIST

        //Code reflects a 'For' Loop for each individual instance of the Student() constructor


        //Student 1 Loop

        for (int i = 0; i < stud1.gradesList.Count; i++)
        {
            double graded1 = stud1.gradesList[i];
            Console.Write($"Student 1: {stud1.Name}, ID: {stud1.ID},  Grade(s): ");
            Console.WriteLine($"{graded1}");
            

        }
        Console.WriteLine();
        Console.WriteLine($" Student 1's Average Grade:  {stud1.CalculateAverageGrade()}");
        Console.WriteLine();
        Console.WriteLine();


        //Student 2 Loop

        for (int i = 0; i < stud2.gradesList.Count; i++)
        {
            double graded2 = stud2.gradesList[i];
            Console.Write($"Student 2: {stud2.Name}, ID: {stud2.ID},   Grade(s): ");
            Console.Write($"{graded2}");
            Console.WriteLine();
        }
        Console.WriteLine();
        Console.WriteLine($" Student 2's Average Grade:  {stud2.CalculateAverageGrade()}");
        Console.WriteLine();
        Console.WriteLine();


        //Student 3 Loop

        for (int i = 0; i < stud3.gradesList.Count; i++)
            {
                double graded3 = stud3.gradesList[i];
                Console.Write($"Student 3: {stud3.Name}, ID: {stud3.ID}  Grade(s): ");
                Console.WriteLine($"{graded3}");
               
            }
        Console.WriteLine();
        Console.WriteLine($" Student 3's Average Grade:  {stud3.CalculateAverageGrade()}");
        Console.WriteLine();
        Console.WriteLine();


        //Student 4 Loop

        for (int i = 0; i < stud4.gradesList.Count; i++)
            {
                double graded4 = stud4.gradesList[i];
                Console.Write($"Student 4: {stud4.Name}, ID: {stud4.ID},  Grade(s): ");
                Console.Write($"{graded4}");
                Console.WriteLine();
            }
        Console.WriteLine();
        Console.WriteLine($" Student 4's Average Grade:  {stud4.CalculateAverageGrade()}");
        Console.WriteLine();
        Console.WriteLine();
        

    }
}






