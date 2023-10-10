using System.ComponentModel.DataAnnotations;

namespace AdoptionMVC.Models;

public class Animal
{
    public int Id { get; set; }
    [Required]
    public string Img { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Description { get; set; }
    [Required]
    public string Breed { get; set; }
    public int Age { get; set; }
}