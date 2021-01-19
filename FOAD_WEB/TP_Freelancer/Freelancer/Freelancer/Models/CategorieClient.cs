using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Models
{
    public class CategorieClient : BaseEntity
    {
        [Column("categorie_id")]
        [Key]
        public int CategorieId { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un nom")]
        [StringLength(50, ErrorMessage = "Limite maximum de caractères : 50")]
        [Display(Name = "Nom de la catégorie")]
        public string Nom { get; set; }

        [DataType(DataType.Text)]
        [Display(Name = "Description de la catégorie")]
        public string Description { get; set; }
    }
}
