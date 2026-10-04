class Program
{
    static void Main(string[] args)
    {
        Student anna = new Student();
        anna.Name = "Анна";
        anna.Age = 20;
        anna.Score = 50;

         
        Print(anna);

        System.Console.WriteLine();

        Student ivan = new Student();
        ivan.Name = "Игор";
        ivan.Age = 25;
        ivan.Score = 70;

         
        Print(ivan);
    }

    static void Print(Student s)
    {
        System.Console.WriteLine(
        "Name: " + s.Name + 
        "\nAge: " + s.Age + 
        "\nScore: " + s.Score
        );
    }
}

class Student
{
    public string? Name;
    public int Age;
    public int Score;
}

/*Почему метод Print, нудно внутри class Program*/