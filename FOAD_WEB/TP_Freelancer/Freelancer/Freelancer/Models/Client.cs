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
        [MaxLength(100, ErrorMessage = "Limite maximum de caractères : 100")]
        public string Nom { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir une adresse e-mail")]
        //[Index(IsUnique = true)]
        [MaxLength(255, ErrorMessage = "Limite maximum de caractères : 255")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez selectionner une catégorie")]
        [ForeignKey("CategorieClient")]
        [Display(Name ="Catégorie")]
        public int CategorieClientId { get; set; }

        public virtual CategorieClient Categorie { get; set; }

    }
}
