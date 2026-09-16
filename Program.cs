
class Program
{
    static void Main()
    {
        // your code runs here
    }
}

courses mathA = new("Math A", 10);

student pete = new("Pete");

pete.Join(mathA); // ok / true
mathA.Enroll(pete); // same result

pete.Join(mathA); // already enrolled

// 11th student
student mr11 = new ("Mr 11");
mr11.Join(mathA) // false / sorry, course is full


//mathA.RolCall(); // List of students, Pete for example
pete.Schedule(); // list of courses pete takes for example Math A
