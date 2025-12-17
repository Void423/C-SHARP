// See https://aka.ms/new-console-template for more information

/* 
* Student Name
 */
using System.IO.Compression;

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

/* 
*Course Credit
*/
int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

/* 
*Course Credit
*/
int  gradeA = 4;
int  gradeB = 3;

/* Course Grade */
int course1grade =  gradeA;
int course2grade =  gradeB;
int course3grade =  gradeB;
int course4grade =  gradeB;
int course5grade =  gradeA;

/* Credit hour */
int totalCreditHours = 0;

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

totalCreditHours = course1Credit + course2Credit + course3Credit + course4Credit + course5Credit;

/* Grade Point */
int totalGradePoints = 0;
totalGradePoints += course1Credit * course1grade;
totalGradePoints += course2Credit * course2grade;
totalGradePoints += course3Credit * course3grade;
totalGradePoints += course4Credit * course4grade;
totalGradePoints += course5Credit * course5grade;


/* Greade Decimal Output */
decimal gradePointAverage = (decimal)totalGradePoints/totalCreditHours;

/* Leading Digit */
int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage*10) % 10;
int secondDigit = (int) (gradePointAverage*100) % 10;

// Console.WriteLine($"{totalGradePoints} {totalCreditHours}");
int x = 7/5;
Console.WriteLine($"Student : {studentName}");
Console.WriteLine("Course\t\tGrade\t\tCreditHours");
Console.WriteLine($"{course1Name}\t\t{course1grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t{course3grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t{course4grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t{course5grade}\t\t{course5Credit}");
Console.WriteLine($"\nFinal GPA:\t\t{leadingDigit}.{firstDigit}{secondDigit}");
Console.WriteLine($"{x}");