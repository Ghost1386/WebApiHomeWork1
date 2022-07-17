using System.ComponentModel.DataAnnotations;
using WebApiHomeWork1.Common.Enums;

namespace WebApiHomeWork1.Common.ViewModels;

public class RecordViewModel
{
    [Required]
    [DataType(DataType.DateTime)]
    public string Date { get; set; }
    
    [Required]
    [DataType(DataType.Text)]
    [MinLength(1)]
    [StringLength(256)]
    public string Text { get; set; }
    
    public RecordStatus Status { get; set; }
}