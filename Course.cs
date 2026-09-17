class Course
{
    public string Name { get; set; } = "";
    public int MaxSeats { get; set; }
    public List<Student> Students { get; set; } = new List<Student>();

    public void Enroll(Student student)
    {
        if (Students.Contains(student))
        {
            Console.WriteLine($"{student.Name} is already enrolled in {Name}.");
        }
        else if (Students.Count < MaxSeats)
        {
            Students.Add(student);
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
        if (Students.Contains(student))
        {
            Students.Remove(student);
            if(student.Courses.Contains(this))
            {
                student.Courses.Remove(this);
            }
        }
        
    }

    public void RollCall()
    {
        Console.WriteLine("Attending students:"); 
        foreach (Student student in Students)
        {
            Console.WriteLine(student.Name);
        }
    }
    public override string ToString()
    {
        return $"{Name} ({Students.Count}/{MaxSeats} places)";
    }
}

