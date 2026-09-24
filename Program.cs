namespace OOP_Project;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter X for P1:");
        int x;
        while(!int.TryParse(Console.ReadLine(), out x)) 
        {
            Console.WriteLine("Invalid input. Enter a number:");
        }   
        Point3D[] points = { 
            new Point3D(x, 5, 5), 
            new Point3D(1, 2, 3), 
            new Point3D(1, 1, 1)
            };
        Array.Sort(points);
    }
}