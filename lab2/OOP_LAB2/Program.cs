namespace Task2
{
    class Numbers
    {
        private int a, b;

        public Numbers() { a = 0; b = 0; }

        public Numbers(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public void NewK(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public void Print()
        {
            Console.WriteLine($"A = {a}, B = {b}");
        }

        public int Nod()
        {
            int x = a, y = b;
            while (x != y)
            {
                if (x > y) x -= y;
                else y -= x;
            }
            return x;
        }

        public int Nok()
        {
            return a * b / Nod();
        }
    }
    class Student
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Faculty { get; set; }
        public int Course { get; set; }

        public void Print()
        {
            Console.WriteLine($"{LastName} {FirstName} {MiddleName}, {BirthDate.ToShortDateString()}, {Faculty}, {Course}");
        }

        public static void FilterByFaculty(Student[] students, string faculty)
        {
            var filtered = students.Where(s => s.Faculty == faculty);
            foreach (var student in filtered) student.Print();
        }

        public static void FilterByYear(Student[] students, int year)
        {
            var filtered = students.Where(s => s.BirthDate.Year > year);
            foreach (var student in filtered) student.Print();
        }
    }
    class Rectangle
    {
        private int a, b;

        public Rectangle(int a, int b)
        {
            this.a = a;
            this.b = b;
        }

        public int A
        {
            get { return a; }
            set { a = value; }
        }

        public int B
        {
            get { return b; }
            set { b = value; }
        }

        public int Perimeter()
        {
            return 2 * (a + b);
        }

        public int Area()
        {
            return a * b;
        }

        public bool IsSquare
        {
            get { return a == b; }
        }

        public void Print()
        {
            Console.WriteLine($"A = {a}, B = {b}, Perimeter = {Perimeter()}, Area = {Area()}, IsSquare = {IsSquare}");
        }
    }

    class Triangle
    {
        private int a, b, c;

        public Triangle(int a, int b, int c)
        {
            if (a + b <= c || a + c <= b || b + c <= a)
                throw new ArgumentException("Невозможно построить треугольник с заданными сторонами.");
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Perimeter()
        {
            return a + b + c;
        }

        public double Area()
        {
            double s = Perimeter() / 2.0;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public (double, double) MedianIntersection()
        {
            return ((a + b + c) / 3.0, (a + b + c) / 3.0);
        }

        public void Print()
        {
            Console.WriteLine($"A = {a}, B = {b}, C = {c}, Perimeter = {Perimeter()}, Area = {Area()}");
        }
    }


}