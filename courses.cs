class Course
{
    public string Name { get; set; } = "";
    public int MaxSeats { get; set; }
    public List<Student> Student { get; set; } = new List<Student>();

    public void Enroll(Student student)
    {
        if (Student.Count < MaxSeats)
        {
            Student.Add(student);
            Console.WriteLine($"{student.Name} has been enrolled in {Name}");
        }
        else 
        {
            Console.WriteLine("Course is full. Enroll next term");
        }
    }
    public void Remove (Student student)
    {
        Student.Remove(student);
    }

    public void RollCall()
    {
        foreach (Student student in Student)
        {
            Console.WriteLine($"{student.Name}");
        }
    }
    public override string ToString()
    {
        return $"{Name} ({Student.Count}/{MaxSeats} places)";
    }
}

