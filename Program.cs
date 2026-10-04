class Program
{
    static void Main(string[] args)
    {
        Student anna = new Student();
        anna.Name = "Анна";
        anna.Age = 20;
        anna.Score = 50;

        System.Console.WriteLine(
        "Name: " + anna.Name + 
        "\nAge: " + anna.Age + 
        "\nScore: " + anna.Score
        );

        System.Console.WriteLine();

        Student ivan = new Student();
        ivan.Name = "Игор";
        ivan.Age = 25;
        ivan.Score = 70;

        System.Console.WriteLine(
        "Name: " + ivan.Name + 
        "\nAge: " + ivan.Age + 
        "\nScore: " + ivan.Score
        );
    }
}

class Student
{
    public string? Name;
    public int Age;
    public int Score;
}