class Student
{
    public string Name { get; set; } = "";
    public List<Course> Courses { get; set; } = new List<Course>();
    public void Join(Course course)
    {
        course.Enroll(this);
    }
    public void Leave(Course course)
    {
        course.Remove(this);
    }
    public void Schedule()
    {
        foreach (Course course in Courses)
        {
            Console.WriteLine($"{course.Name}");
        }
    }
    public override string ToString()
    {
        return $"{Name}";
    }
}

