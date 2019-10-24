//Bilal Sayed 6/13/19
using System;
using System.Linq;
using System.Collections.Generic;

namespace Lab1
{
   class Program
   {
      static void Main()
      {
         //Get number of grades
         Console.Write("Please enter the number of grades: ");
         int numberOfGrades = Convert.ToInt32(Console.ReadLine());

         //create list
         var grades = new List<float>();

         //number to increment while loop
         int gradeNumber = 0;
         //while loop to get input
         while (gradeNumber < numberOfGrades)
         {
            Console.Write("Please enter grade #" + (gradeNumber + 1) + ": ");
            grades.Add(float.Parse(Console.ReadLine()));
            gradeNumber++;
         }

         //call median method
         Median(grades);


         //median method
         void Median(List<float> list) {

            //LINQ query
            var sortedList =
               from element in list
               orderby element
               select element;
            
            //variable for midway point of the list
            int midwayPoint = (list.Count() / 2);
            //median variable
            float median = 0;

            //if loop to determine median based on even or odd number of input
            if ((list.Count() % 2) == 0)
            {
               median = ((sortedList.ElementAt(midwayPoint) + sortedList.ElementAt((midwayPoint - 1))) / 2);
            }
            else
            {
               median = sortedList.ElementAt(midwayPoint);
            }

            //output result
            Console.Write("The median grade is " + median);
         }  

      }
   }
}
