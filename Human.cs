public class Human
{
    public string firstName;
    public string lastName;

    public Human(string firstName, string lastName){
        this.firstName = firstName;
        this.lastName = lastName;
    }

    public void IntroduceMyself()
    {
        Console.WriteLine($"I'm {this.firstName} {this.lastName}");
    }
}