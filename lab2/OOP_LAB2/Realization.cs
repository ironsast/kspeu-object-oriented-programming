using System;
using System.Linq;
using Task2;
class Program
{
    static void Main(string[] args)
    {
        // Часть 1: Проверка класса Numbers
        Numbers num1 = new Numbers(36, 60);
        num1.Print();
        Console.WriteLine($"НОД: {num1.Nod()}");
        Console.WriteLine($"НОК: {num1.Nok()}");

        num1.NewK(15, 45);
        num1.Print();
        Console.WriteLine($"НОД: {num1.Nod()}");
        Console.WriteLine($"НОК: {num1.Nok()}");

        // Часть 2: Проверка класса Student
        Student[] students = new Student[]
        {
            new Student { LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", BirthDate = new DateTime(2000, 5, 15), Faculty = "Физика", Course = 3 },
            new Student { LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", BirthDate = new DateTime(1999, 8, 22), Faculty = "Математика", Course = 2 },
            new Student { LastName = "Сидоров", FirstName = "Сидор", MiddleName = "Сидорович", BirthDate = new DateTime(2001, 12, 5), Faculty = "Физика", Course = 1 },
            new Student { LastName = "Кузнецов", FirstName = "Алексей", MiddleName = "Алексеевич", BirthDate = new DateTime(2002, 3, 18), Faculty = "Математика", Course = 3 }
        };

        Console.WriteLine("\nСтуденты факультета 'Физика':");
        Student.FilterByFaculty(students, "Физика");

        Console.WriteLine("\nСтуденты, родившиеся после 2000 года:");
        Student.FilterByYear(students, 2000);

        // Часть 3: Проверка класса Rectangle
        Rectangle rect1 = new Rectangle(5, 10);
        rect1.Print();

        rect1.A = 8;
        rect1.B = 8;
        rect1.Print();

        // Часть 4: Проверка класса Triangle
        try
        {
            Triangle triangle1 = new Triangle(3, 4, 5);
            triangle1.Print();
            Console.WriteLine($"Точка пересечения медиан: {triangle1.MedianIntersection()}");

            // Треугольник с неправильными сторонами
            Triangle triangle2 = new Triangle(1, 2, 8);  // Ошибка
        }
        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
