
class Program
{
    static void Main()
    {
        Course mathA = new();
        mathA.Name = "Math A";
        mathA.MaxSeats = 10;
        Console.WriteLine("--- Enrolling Pete via Course.Enroll ---");
        Student pete = new();
        pete.Name = "Pete";
        mathA.Enroll(pete);
        Console.WriteLine("--- should NOT create a duplicate ---");
        pete.Join(mathA);
        pete.Schedule();
        Console.WriteLine("--- Enrolling Mr11 (2/10 seats) ---");
        Student mr11 = new ();
        mr11.Name = "Mr11";
        mr11.Join(mathA);
        mr11.Schedule();
        Console.WriteLine("--- Enrolling Ahmad (3/10 seats) ---");
        Student Ahmad = new();
        Ahmad.Name = "Ahmad";
        Ahmad.Join(mathA);
        Ahmad.Schedule();
        Console.WriteLine("--- Enrolling Alex (4/10 seats) ---");
        Student Alex = new();
        Alex.Name = "Alex";
        Alex.Join(mathA);
        Alex.Schedule();
        Console.WriteLine("--- Enrolling Jhon (5/10 seats) ---");
        Student Jhon = new();
        Jhon.Name = "Jhon";
        Jhon.Join(mathA);
        Jhon.Schedule();
        Console.WriteLine("--- Enrolling Lester (6/10 seats) ---");
        Student Lester = new();
        Lester.Name = "Lester";
        Lester.Join(mathA);
        Lester.Schedule();
        Console.WriteLine("--- Enrolling Michel (7/10 seats) ---");
        Student Michel = new();
        Michel.Name = "Michel";
        Michel.Join(mathA);
        Michel.Schedule();
        Console.WriteLine("--- Enrolling Daniel (8/10 seats) ---");
        Student Daniel = new();
        Daniel.Name = "Daniel";
        Daniel.Join(mathA);
        Daniel.Schedule();
        Console.WriteLine("--- Enrolling Monika (9/10 seats) ---");
        Student Monika = new();
        Monika.Name = "Monika";
        Monika.Join(mathA);
        Monika.Schedule();
        Console.WriteLine("--- Enrolling Henrik (10/10 seats — course now full) ---");
        Student Henrik = new();
        Henrik.Name = "Henrik";
        Henrik.Join(mathA);
        Henrik.Schedule();
        Console.WriteLine("--- Enrolling Tina — course is full, this should be REJECTED  ---");
        Student Tina = new();
        Tina.Name = "Tina";
        Tina.Join(mathA);
        Tina.Schedule();
        Console.WriteLine("--- Final roster  ---");
        mathA.RollCall();
        Student sarah = new();
        sarah.Name = "Sarah";
        sarah.Leave(mathA);
        Console.WriteLine("Sarah's Leave call didn't crash the program.");
        Console.WriteLine(mathA);

        Console.WriteLine("--- Removing Pete, who IS enrolled ---");
        pete.Leave(mathA);
        pete.Schedule();       // should now print nothing for Pete
        mathA.RollCall();      // Pete should be gone, everyone else still there 
    }
}