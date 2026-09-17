class Student
{
    public string Name { get; set; } = "";
    public List<Course> Courses { get; set; } = new List<Course>();
    public void Join(Course course)
    {
        Courses.Add(course);
        course.Enroll(this);
    }
}

