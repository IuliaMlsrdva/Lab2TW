using eUseControl.Models.Entities.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eUseControl.Models.Entities.User
{
   public class UDbTable
    {
         [Key]
         [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
          public int Id { get; set; }
        [Required]
          [Display(Name = "Username")]
          [StringLength(30, MinimumLength = 5, ErrorMessage = "Username can't be longer than 30 characters")]
        public string UserName { get; set; }
        public string Username { get; set; }
        [Required]
         [Display(Name = "Password")]
         [StringLength(30, MinimumLength = 5, ErrorMessage = "Username can't be longer than 30 characters")]
        public string UserPassword { get; set; }

        [Required]
        [Display(Name = "Emal Address")]
        [StringLength(30)]
        public string Email { get; set; }

         [DataType(DataType.Date)]
        public DateTime SessionDate { get; set; }

        [StringLength(30)]
        public string LasIp { get; set; }
        public Urole Level { get; set; }


    }

}
