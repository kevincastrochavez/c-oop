public class Human
{
    public string firstName;
    public string lastName;
    public string eyeColor;
    public string age;

    public Human(string firstName, string lastName, string eyeColor, string age){
        this.firstName = firstName;
        this.lastName = lastName;
        this.eyeColor = eyeColor;
        this.age = age;
    }

    public void IntroduceMyself()
    {
        Console.WriteLine($"I'm {this.firstName} {this.lastName}, with {eyeColor} eyes and {age} years old");
    }
}