namespace Rosier.Blog.Models;

public class Entry
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Content { get; set; }
    public DateTime PublishDate { get; set; }
}