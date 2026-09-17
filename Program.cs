
class Program
{
    static void Main()
    {
        Course mathA = new();
        mathA.Name = "Math A";
        mathA.MaxSeats = 10;
        Console.WriteLine("--- ... ---");
        Student pete = new();
        pete.Name = "Pete";
        mathA.Enroll(pete);
        pete.Join(mathA);
        pete.Schedule();
        Console.WriteLine("--- ... ---");
        Student mr11 = new ();
        mr11.Name = "Mr11";
        mr11.Join(mathA);
        mr11.Schedule();
        Console.WriteLine("--- ... ---");
        Student Ahmad = new();
        Ahmad.Name = "Ahmad";
        Ahmad.Join(mathA);
        Ahmad.Schedule();
        Console.WriteLine("--- ... ---");
        Student Alex = new();
        Alex.Name = "Alex";
        Alex.Join(mathA);
        Alex.Schedule();
        Console.WriteLine("--- ... ---");
        Student Jhon = new();
        Jhon.Name = "Jhon";
        Jhon.Join(mathA);
        Jhon.Schedule();
        Console.WriteLine("--- ... ---");
        Student Lester = new();
        Lester.Name = "Lester";
        Lester.Join(mathA);
        Lester.Schedule();
        Console.WriteLine("--- ... ---");
        Student Michel = new();
        Michel.Name = "Michel";
        Michel.Join(mathA);
        Michel.Schedule();
        Console.WriteLine("--- ... ---");
        Student Daniel = new();
        Daniel.Name = "Daniel";
        Daniel.Join(mathA);
        Daniel.Schedule();
        Console.WriteLine("--- ... ---");
        Student Monika = new();
        Monika.Name = "Monika";
        Monika.Join(mathA);
        Monika.Schedule();
        Console.WriteLine("--- ... ---");
        Student Henrik = new();
        Henrik.Name = "Henrik";
        Henrik.Join(mathA);
        Henrik.Schedule();
        Console.WriteLine("--- ... ---");
        Student Tina = new();
        Tina.Name = "Tina";
        Tina.Join(mathA);
        Tina.Schedule();
        Console.WriteLine("--- ... ---");
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