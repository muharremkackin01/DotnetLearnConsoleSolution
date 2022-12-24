/*
 Start a student point calculater
 */

/*
    Statement -> IF ELSE ELSE IF [Switch - Case]
    Loop -> for + foreach + while
    Listeler
    Sınıflar -> Attribute + Method
 */


using System;

List<Ogrenci> Students = new List<Ogrenci>();

Console.WriteLine("Sinifta kac ogrenci var?");

int max_students = Convert.ToInt32(Console.ReadLine());

for (var sayac = 0;sayac < max_students;sayac = sayac + 1)
{
    Console.WriteLine($"{sayac + 1}. ogrencinin adini giriniz.");
    var Name = Console.ReadLine();
    Console.WriteLine($"{sayac + 1}. ogrencinin puanini giriniz.");
    var Point = Console.ReadLine();

    Students.Add(new Ogrenci() { Name = Name, Point = Convert.ToInt32(Point) });
}

foreach(var student in Students)
{
    Console.WriteLine($"{student.Name} adli ogrencinin notu: {student.Note()}, Puani: {student.Point}");
}
Console.ReadLine();
public class Ogrenci { 
    public string Name { get; set; }
    public int Point { get; set; }

    public string Note()
    {
        if (this.Point <= 49)
        {
            return "FF";
        } else
        {
            return "AA";
        }
    }
}