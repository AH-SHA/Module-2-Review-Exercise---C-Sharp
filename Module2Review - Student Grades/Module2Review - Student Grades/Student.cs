using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2Review___Student_Grades
{
    public class Student
    {
        

        //CLASS PROPERTIES
        public string Name { get; set; }
        public int ID { get; set; }

        public List<double> gradesList { get; set; } = new();

                //Questions Later:
                    //Old Code:  public List<double> gradesList { get; set; } = new List <double>();
                    //Old Code: public List <double> Grades {get; set;} 
                    //Old Code: public static List<double> Grades {get; set;} = new List<double>();


        // 3 METHODS Needed

        // METHOD 1  - Method to add values to the gradesList created above
        public void AddGrade(double grade)
        {
            gradesList.Add(grade);
            
        }


        //METHOD 2 - allows method overloading for the AddGrade method
        public void AddGrade(params double[] grades)
        {
            gradesList.AddRange(grades);
        }


        //METHOD 3 - Calcs Average of all grades in the gradesList
        public double CalculateAverageGrade()
        {
            
            if (gradesList.Count == 0)
            {
                return 0;
            }
            else
            {
                double avgGrade = Queryable.Average(gradesList.AsQueryable());
                return avgGrade;
            }


        }

    }

    
}
