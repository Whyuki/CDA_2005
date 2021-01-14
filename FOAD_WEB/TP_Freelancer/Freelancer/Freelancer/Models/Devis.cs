using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Freelancer.Models
{
    public class Devis
    {
        [Key]
        [Column("devis_id")]
        public int DevisId { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un état")]
        [StringLength(10, ErrorMessage = "Limite maximum de caractères : 10")]
        public char Etat { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir une date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un montant")]
        public int Montant { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date finale")]
        public DateTime DevisDateFinale { get; set; }

        [Display(Name = "Montant final")]
        public int MontantFinal { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez renseigner une mission")]
        [ForeignKey("Mission")]
        public int MissionId { get; set; }

    }
}
