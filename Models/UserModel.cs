using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="First name is required.")]
        public string FirstsName { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="last name is required.")]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Password is required.")]
        public string Password { get; set; }
        [Required(AllowEmptyStrings =false,ErrorMessage ="Email is required.")]
        public string Email { get; set; }
        public bool IsEmailConfirmed { get; set; }
        public DateTime? EmailConfirmationDate { get; set; }
    }
}
