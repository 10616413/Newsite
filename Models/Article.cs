using System.ComponentModel.DataAnnotations;
namespace NewsiteA.Models;

public class Article
{
    public int Id {get; set;}
    public string? Title {get; set;}
    [DataType(DataType.Date)]
    public DateTime ReleaseDate {get; set;}
    public string? Genre {get; set;}

    public string? Text {get; set;}
}