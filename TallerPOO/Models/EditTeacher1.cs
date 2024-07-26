using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPOO.Models;

public static class EditTeacher1
{
    public static void EditName(int ubicationTeacher)
    {
        Console.Write("Enter the new name of the teacher: ");
        string newName = verification.NormalizationOfString("Enter the new name of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].Name = newName;
    }
    public static void EditSurname(int ubicationTeacher)
    {
        Console.Write("Enter the new surname of the teacher: ");
        string newsurname = verification.NormalizationOfString("Enter the new surname of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].Surname = newsurname;
    }

    public static void EditTypeOfDocument(int ubicationTeacher)
    {
        Console.Write("Enter the new type of document of the teacher: ");
        string newTOD = verification.NormalizationOfString("Enter the new type of document of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].TypeOfDocument = newTOD;
    }
    public static void EditDocumentNumber(int ubicationTeacher)
    {
        Console.Write("Enter the new document number of the teacher: ");
        string newDN = verification.NormalizationOfString("Enter the new document number of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].DocumentNumber = newDN;
    }

    public static void EditEmail(int ubicationTeacher)
    {
        Console.Write("Enter the new email of the teacher: ");
        string newEmail = verification.NormalizationEmail("Enter the new email of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].Email = newEmail;
    }

    public static void EditPhoneNumber(int ubicationTeacher)
    {
        Console.Write("Enter the new phone number of the teacher: ");
        string newPN = verification.NormalizationOfString("Enter the new phone number of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].PhoneNumber = newPN;
    }
    public static void EditSubject(int ubicationTeacher)
    {
        Console.Write(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the new actual subject: ");
        string newSubject = verification.verificateSubject(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the new actual subject: ");

        AppAdministrator.Teachers[ubicationTeacher].Subjects = newSubject;
    }

    public static void EditSalary(int ubicationTeacher)
    {
        Console.Write("Enter the new salary of the teacher: ");
        double newSalary = verification.verificateDouble("Enter the new care taker of the teacher: ");

        AppAdministrator.Teachers[ubicationTeacher].Salary = newSalary;
    }

    public static void EditEmploymentDate(int ubicationTeacher)
    {
        Console.Write("Enter the new year: ");
        int newYear = verification.verificateIntYear("Enter the new year: ");

        Console.Write("Enter the new month: ");
        int newMonth = verification.verificateIntMonth("Enter the new month: ");

        Console.Write("Enter the new day: ");
        int newDay = verification.verificateIntDay("Enter the new day:",newMonth);

        AppAdministrator.Teachers[ubicationTeacher].EmploymentDate = new DateTime(newYear,newMonth,newDay);
    }

    public static void EditCourse(int ubicationTeacher)
    {
        int coursesLength = AppAdministrator.Teachers[ubicationTeacher].Courses.Count();
        for (int i = 0; i < coursesLength; i++)
        {
        Console.WriteLine($"{i+1}.   {AppAdministrator.Teachers[ubicationTeacher].Courses[i]}");
        }
        Console.Write("Enter the number of the course you want to change: ");
        int courseToReplace = verification.numberInRange("Enter the number of the course you want to change: ",1,coursesLength);
        Console.Write(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");
        string newCourse = verification.verificateSubject(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the subject: ");
        
        AppAdministrator.Teachers[ubicationTeacher].Courses[courseToReplace-1] = newCourse;

    }
}