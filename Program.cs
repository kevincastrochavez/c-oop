public class Program
{
    public static void Main(string[] args)
    {
        Human kevin = new Human("Kevin", "Castro", "brown", "25");
        kevin.IntroduceMyself();

        Human citlalli = new Human("Citlalli", "Gonzalez", "brown", "26");
        citlalli.IntroduceMyself();

        Human basicHuman = new Human();
    }
}