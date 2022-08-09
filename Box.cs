class Box
{
    // public int lenght;
    private int length = 3;
    private int height;
    public int width;
    public int volume;

    public int Width { get; set; }

    public Box(int length, int width, int height)
    {
        this.length = length;
        this.height = height;
        Width = width;
    }

    // Property
    // Same as public int Height { get; set; }
    public int Height
    {
        get
        {
            return height;
        }

        set
        {
            if (value < 0)
            {
                height = -value;
            } 
            else 
            { 
                height = value;
            }
        }
    }

    // Setter
    public void SetLength(int length)
    {
        this.length = length;
    }

    // Getter
    public int GetLength()
    {
        return this.length;
    }

    public int GetVolume()
    {
        return this.height * this.width * this.length;
    }

    public void DisplayInfo()
    {
        this.volume = this.length * this.height * Width;
        Console.WriteLine($"Lenght is {this.length}, height is {height}, width is {Width}. So the volume is {volume}");
    }
}