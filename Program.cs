using System.Runtime.CompilerServices;
public class Program
{
    public static void Main(string[] args)
    {
        // Human kevin = new Human("Kevin", "Castro", "brown", "25");
        // kevin.IntroduceMyself();

        // Human citlalli = new Human("Citlalli", "Gonzalez", "brown", "26");
        // citlalli.IntroduceMyself();

        // Human basicHuman = new Human();

        Box box = new Box();
        // Allowable when property is public
        // box.lenght = 3;
        box.SetLength(10);
        box.height = 4;
        box.width = 5;

        box.DisplayInfo();
        Console.WriteLine(box.GetVolume());
    }
}