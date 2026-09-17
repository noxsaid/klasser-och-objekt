
class Program
{
    static void Main()
    {
        Course mathA = new("Math A", 10);

Student pete = new("Pete");

pete.Join(mathA); // ok / true
mathA.Enroll(pete); // same result

pete.Join(mathA); // already enrolled

// 11th student
Student mr11 = new ("Mr 11");
mr11.Join(mathA) // false / sorry, course is full


//mathA.RolCall(); // List of students, Pete for example
pete.Schedule(); // list of courses pete takes for example Math A

    }
}

