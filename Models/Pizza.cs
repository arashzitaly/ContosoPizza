using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Pizza
{
    [Required]
    public int Id { get; set; }
    public string? Name { get; set; }
    public bool IsGlutenFree { get; set; }
    public PizzaSize Size { get; set; }

    [Range(0.01, 9999.99)]
    public decimal Price{ get; set;}

    public enum PizzaSize { Small, Medium, Large }
}