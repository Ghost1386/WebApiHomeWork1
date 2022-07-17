using System.ComponentModel.DataAnnotations;

namespace WebApiHomeWork1.Common.ViewModels;

public class UserViewModel
{
    [Required]
    [DataType(DataType.Text)]
    [MinLength(6)]
    [StringLength(18)]
    public string Name { get; set; }
    
    [Required]
    [DataType(DataType.EmailAddress)]
    [MinLength(5)]
    [StringLength(30)]
    public string Email { get; set; }

    [Required]
    [DataType(DataType.PhoneNumber)]
    [MinLength(6)]
    [StringLength(16)]
    public string Number { get; set; }

    [Required]
    [DataType(DataType.Password)]
    [MinLength(6)]
    [StringLength(16)]        
    public string Password { get; set; }
}