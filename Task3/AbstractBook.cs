abstract class AbstractBook :Readable
{
    

    public string Title { get; set; }  
    public string Author { get; set; } 
    public void Read()
    {
        Console.WriteLine($"Reading the book '{Title}' by {Author}.");
    }
}

