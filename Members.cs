class Members
{
    // Private field
    private string memberName;
    private string jobTitle;
    private int salary;

    // Public field
    public int age;

    // Constructor
    public Members()
    {
        Console.WriteLine("Object created");
        age = 25;
        memberName = "Kevin";
        salary = 80000;
        jobTitle = "Web Developer";
    }

    // Property
    public string JobTitle 
    { 
        get
        {
            return jobTitle;
        } 
        set
        {
            jobTitle = value;
        } 
    }

    // Method
    public void Introducing(bool isFriend)
    {
        if (isFriend)
        {
            SharingPrivateInfo();
        }
        else
        {
            Console.WriteLine($"Hi! My name is {memberName} and my Job Title is {jobTitle}. I'm {age} years old");
        }
    }

    private void SharingPrivateInfo()
    {
        Console.WriteLine($"My salary is {this.salary}");
    }

    ~Members()
    {
        Console.WriteLine("Destruction of Members object");
    }
}