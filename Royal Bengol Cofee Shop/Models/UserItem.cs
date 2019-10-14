using System.ComponentModel.DataAnnotations;

namespace Royal_Bengol_Cofee_Shop.Models
{
    public class UserItem
    {
        [Required(ErrorMessage = "Please type the name")]
        [DataType(DataType.Text)]
        [StringLength(20, ErrorMessage = "Do not enter more than 20 characters")]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Currency)]
        [Range(1, 150, ErrorMessage = "Please enter correct value from 1 to 150")]
        public float Price { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Please enter correct value from 1 to 1000")]
        public int Quantity { get; set; }

        [Required]
        [StringLength(2000, ErrorMessage = "Do not enter more than 2000 characters")]
        public string Description { get; set; }

    }
}
