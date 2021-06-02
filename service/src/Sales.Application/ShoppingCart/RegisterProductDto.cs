namespace Sales.Application.ShoppingCart
{
    using System.ComponentModel.DataAnnotations;

    public class RegisterProductDto //DTO - Data Transfer Object
    {
        [Required]
        public string ProductName { get; set; }
    }
}