using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class Client
    {
        [Column("client_id")]
        [Key]
        public int ClientId { get; set; }

        //[Index(IsUnique = true)]
        [MaxLength(100)]
        public string Nom { get; set; }

        [Required]
        //[Index(IsUnique = true)]
        [MaxLength(255)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [ForeignKey("CategorieClient")]
        [Display(Name ="Catégorie")]
        public int CategorieClientId { get; set; }

        public virtual CategorieClient Categorie { get; set; }

    }
}
