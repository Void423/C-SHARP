using System;

namespace StudentGradesApp
{
   class Student
   {
      public static void Main(string[] args)
      {

         /* Student Assigment */
         int totalStudentAssigment = 5;

         /* 
         * Declare Global Variable from student
         Variable yang akan banyak dipakai dari awal sampai akhir
          */
         string[] studentNames =  [ "Sophia", "Andrew", "Emma", "Logan" ];
         int[] gradeSophia = [90,78,67,93,100,80];
         int[] gradeAndrew = [90,60,50,40,30];
         int[] gradeEmma = [90,78,67,93,30];
         int[] gradeLogan = [90,60,86,76,98];

         int[] studentGrade = new int[10];
         string studentLetterGrade = "";


         /* Header */
         Console.WriteLine("Student Name\t\tGrade\t\tGrade In Letter");

         /* Foreach statement */
         foreach (string name in studentNames)
         {
            string currentStudent = name;

            if (currentStudent == "Sophia")
            {
               studentGrade = gradeSophia;
            } else if (currentStudent == "Andrew")
            {
               studentGrade = gradeAndrew;
            } else if (currentStudent == "Emma")
            {
               studentGrade = gradeEmma;
            } else if (currentStudent == "Logan")
            {
               studentGrade = gradeLogan;
            }

            decimal totalGrade = 0;
            int sumAssigmentScore = 0;
            int sumAssigment = 0; // ini sama dengan counter
            foreach (int score in studentGrade)
            {
               sumAssigment += 1; // kalo counter lebih dari 6 maka akan ditambahkan bonus 10%

               /* 
                ! Jika Iterasi lebih dari 5 assigmentn maka iterasi selanjutnya akan mendapatkan extra bonus 10%
                ! jika kurang sama dengan 5 assigment maka akan dilakukan penjumlahan secara menyeluruh dan / 5
                */

               if (sumAssigment <= totalStudentAssigment)
               {
                  sumAssigmentScore += score;
               } else
               {
                  sumAssigmentScore += score * 10/100;
               }
            }
            totalGrade = (decimal)sumAssigmentScore / totalStudentAssigment;

            if (totalGrade >= 90)
            {
               studentLetterGrade = "A";
            } else if (totalGrade >= 80)
            {
               studentLetterGrade = "B";
            } else if (totalGrade >= 70)
            {
               studentLetterGrade = "C";
            } else if (totalGrade >= 60)
            {
               studentLetterGrade = "D";
            } else
            {
               studentLetterGrade = "E";
            }

            Console.WriteLine($"{currentStudent}\t\t{totalGrade}\t\t\t{studentLetterGrade}");
         }
         Console.ReadKey();
      }
   }
}