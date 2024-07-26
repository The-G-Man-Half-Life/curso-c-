namespace TallerPOO.Models;

public static class EditStudent1
{
    public static void EditName(int ubicationStudent)
    {
        Console.Write("Enter the new name of the student: ");
        string newName = verification.NormalizationOfString("Enter the new name of the student: ");

        AppAdministrator.Students[ubicationStudent].Name = newName;
    }
    public static void EditSurname(int ubicationStudent)
    {
        Console.Write("Enter the new surname of the student: ");
        string newsurname = verification.NormalizationOfString("Enter the new surname of the student: ");

        AppAdministrator.Students[ubicationStudent].Surname = newsurname;
    }

    public static void EditTypeOfDocument(int ubicationStudent)
    {
        Console.Write("Enter the new type of document of the student: ");
        string newTOD = verification.NormalizationOfString("Enter the new type of document of the student: ");

        AppAdministrator.Students[ubicationStudent].TypeOfDocument = newTOD;
    }
    public static void EditDocumentNumber(int ubicationStudent)
    {
        Console.Write("Enter the new document number of the student: ");
        string newDN = verification.NormalizationOfString("Enter the new document number of the student: ");

        AppAdministrator.Students[ubicationStudent].DocumentNumber = newDN;
    }

    public static void EditEmail(int ubicationStudent)
    {
        Console.Write("Enter the new email of the student: ");
        string newEmail = verification.NormalizationEmail("Enter the new email of the student: ");

        AppAdministrator.Students[ubicationStudent].Email = newEmail;
    }

    public static void EditPhoneNumber(int ubicationStudent)
    {
        Console.Write("Enter the new phone number of the student: ");
        string newPN = verification.NormalizationOfString("Enter the new phone number of the student: ");

        AppAdministrator.Students[ubicationStudent].PhoneNumber = newPN;
    }
    public static void EditCareTaker(int ubicationStudent)
    {
        Console.Write("Enter the new phone care taker of the student: ");
        string newCT = verification.NormalizationOfString("Enter the new care taker of the student: ");

        AppAdministrator.Students[ubicationStudent].CareTaker = newCT;
    }

    public static void EditActualCourse(int ubicationStudent)
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
        string newAC = verification.verificateSubject(@$"
1.Math
2.Physic
3.Chemistry
4.History
5.Languages
6.Biology
7.Technology
8.P.Education

Enter the number of the new actual subject: ");

        AppAdministrator.Students[ubicationStudent].ActualCourse = newAC;
    }

    public static void EditBirthDate(int ubicationStudent)
    {
        Console.Write("Enter the new year: ");
        int newYear = verification.verificateIntYear("Enter the new year: ");

        Console.Write("Enter the new month: ");
        int newMonth = verification.verificateIntMonth("Enter the new month: ");

        Console.Write("Enter the new day: ");
        int newDay = verification.verificateIntDay("Enter the new day:",newMonth);

        AppAdministrator.Students[ubicationStudent].BirthDate = new DateOnly(newYear,newMonth,newDay);
    }

    public static void EditGrade(int ubicationStudent)
    {
        int gradesLength = AppAdministrator.Students[ubicationStudent].Grades.Count();
        for (int i = 0; i < gradesLength; i++)
        {
        Console.WriteLine($"{i+1}.   {AppAdministrator.Students[ubicationStudent].Grades[i]}");
        }
        Console.Write("Enter the number of the grade you want to change: ");
        int gradeToReplace = verification.numberInRange("Enter the number of the grade you want to change: ",1,gradesLength);
        Console.Write("Enter the new grade: ");
        double newGrade = verification.verificateDouble("Enter the new grade: ");
        
        AppAdministrator.Students[ubicationStudent].Grades[gradeToReplace-1] = newGrade;

    }
}