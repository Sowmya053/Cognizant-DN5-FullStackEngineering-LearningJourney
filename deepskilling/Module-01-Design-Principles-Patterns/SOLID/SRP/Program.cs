using System;

class Student
{
    public string Name { get; set; } = "";
}

class StudentRepository
{
    public void Save(Student student)
    {
        Console.WriteLine($"Student {student.Name} saved to database.");
    }
}

class ReportGenerator
{
    public void Generate(Student student)
    {
        Console.WriteLine($"Report generated for {student.Name}.");
    }
}

class Program
{
    static void Main()
    {
        Student student = new Student();
        student.Name = "Madhumitha";

        StudentRepository repository = new StudentRepository();
        repository.Save(student);

        ReportGenerator reportGenerator = new ReportGenerator();
        reportGenerator.Generate(student);
    }
}