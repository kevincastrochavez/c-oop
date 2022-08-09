class Box
{
    // public int lenght;
    private int length = 3;
    public int height;
    public int width;
    public int volume;

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
        this.volume = this.length * this.height * this.width;
        Console.WriteLine($"Lenght is {this.length}, height is {height}, width is {width}. So the volume is {volume}");
    }
}