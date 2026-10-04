class Program
{
    static void Main(string[] args)
    {
        Student st1 = new Student();
        st1.Name = "Abdullo";
        st1.Age = 18;
        st1.Score = 90;

        System.Console.WriteLine(
        "Name: " + st1.Name + 
        "\nAge: " + st1.Age + 
        "\nScore: " + st1.Score
        );

        System.Console.WriteLine();

        Student st2 = new Student();
        st2.Name = "Egor";
        st2.Age = 28;
        st2.Score = 95;

        System.Console.WriteLine(
        "Name: " + st2.Name + 
        "\nAge: " + st2.Age + 
        "\nScore: " + st2.Score
        );
    }
}

class Student
{
    public string? Name;
    public int Age;
    public int Score;
}