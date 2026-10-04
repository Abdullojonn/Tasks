class Program
{
    static void Main(string[] args)
    {
        Student anna = new Student();
        anna.Name = "Анна";
        anna.Age = 20;
        anna.Score = 50;

        AddScore(anna, 30);
        Print(anna);

        System.Console.WriteLine();

        Student ivan = new Student();
        ivan.Name = "Иван";
        ivan.Age = 25;
        ivan.Score = 70;

        AddScore(ivan, 20);
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
    
    static void AddScore(Student s, int points)
    {
        s.Score = s.Score + points;
    }
}

class Student
{
    public string? Name;
    public int Age;
    public int Score;
}