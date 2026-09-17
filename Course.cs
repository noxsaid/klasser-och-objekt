class Course
{
    public string Name { get; set; } = "";
    public int MaxSeats { get; set; }
    public List<Student> Student { get; set; } = new List<Student>();

    public void Enroll(Student student)
    {
        if (Student.Contains(student))
        {
            Console.WriteLine($"{student.Name} is already enrolled in {Name}.");
        }
        else if (Student.Count < MaxSeats)
        {
            Student.Add(student);
            if (!student.Courses.Contains(this))
            {
                student.Courses.Add(this);
            }
            Console.WriteLine($"{student.Name} has been enrolled in {Name}");
        }
        else
        {
            Console.WriteLine("Course is full. Enroll next term");
        }
    }
    public void Remove (Student student)
    {
        if (Student.Contains(student))
        {
            Student.Remove(student);
            if(student.Courses.Contains(this))
            {
                student.Courses.Remove(this);
            }
        }
        
    }

    public void RollCall()
    {
        Console.WriteLine("Attending students:"); 
        foreach (Student student in Student)
        {
            Console.WriteLine(student.Name);
        }
    }
    public override string ToString()
    {
        return $"{Name} ({Student.Count}/{MaxSeats} places)";
    }
}

