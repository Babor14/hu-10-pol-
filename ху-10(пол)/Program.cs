// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//college[] collegea = new college[2];
//for(int i=0;i<collegea.Length;i++)
// {
//    Console.WriteLine($"название колледжа:");
//    string name=Console.ReadLine();
//    Console.WriteLine($"кол-во поступивших:");
//    int studentcount=int.Parse(Console.ReadLine()); 
//    Console.WriteLine($"кол-во выпускников:");
//    int studentend=int.Parse(Console.ReadLine());
//    collegea[i] = new college(name, studentcount, studentend);
//}
//public class college
//{
//    public string name { get; set; }
//    public int studentcount { get; set; }
//    public int studentend { get; set; }

//    public college(string name, int studentcount, int studentend)
//    {
//        this.name = name;
//        this.studentcount = studentcount;
//        this.studentend = studentend;

//    }
//    public virtual void studentspecial()
//    {

//    }
//    public specialty(string name, int studentcount,int studentend)
//    {


//    }
//}
//public class specialty : college
//{

//    public override void studentspecial()
//    {
//        base.studentspecial();
//    }
//}
using System;
public class College
{
    public string Name { get; set; }
    public int Students { get; set; }
    public int Graduates { get; set; }

    public College(string name, int students, int graduates)
    {
        Name = name;
        Students = students;
        Graduates = graduates;
    }

    public double Count()
    {
        return (double)Graduates / Students;
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название учебного заведения: {Name}");
        Console.WriteLine($"Количество студентов, зачисленных на 1-й курс: {Students}");
        Console.WriteLine($"Количество выпускников: {Graduates}");
    }
}

public class Institute : College
{
    public double P { get; set; }

    public Institute(string name, int enrolledStudents, int graduates, double p)
        : base(name, enrolledStudents, graduates)
    {
        P = p;
    }

    public new double Count()
    {
        return P * base.Count();
    }

    public new void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Процент выпускников, работающих по специальности: {P}");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        College collegeObj = new College("Университет", 1000, 500);
        collegeObj.DisplayInfo();
        Console.WriteLine($"Университет: {collegeObj.Count()}");   
        Institute institObj = new Institute("Институт", 800, 400, 0.8);
        institObj.DisplayInfo();
        Console.WriteLine($"Институт: {institObj.Count()}");
    }
}

