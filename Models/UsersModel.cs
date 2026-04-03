using System;
using System.ComponentModel.DataAnnotations;
namespace UMS.Models
{
    public class UsersModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string firstName { get; set; } = string.Empty;
        [MaxLength(100)]
        public string username { get; set; } = string.Empty;
        public string email { get; set; } = string.Empty;

    }
}
