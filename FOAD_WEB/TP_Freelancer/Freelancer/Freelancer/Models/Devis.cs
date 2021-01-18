using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Freelancer.Models
{
    public class Devis : BaseEntity
    {
        public Devis()
        {
        }

        public Devis(string etatDevis, DateTime date, int montant, int missionId)
        {
            //DevisId = devisId;
            EtatDevis = etatDevis;
            Date = date;
            Montant = montant;
            MissionId = missionId;
            //Mission = mission;
        }

        [Key]
        [Column("devis_id")]
        public int DevisId { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un état")]
        [StringLength(10, ErrorMessage = "Limite maximum de caractères : 10")]
        [Display(Name = "État du devis")]
        public string EtatDevis { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir une date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Range(1, Int64.MaxValue, ErrorMessage = "Montant positif attendu")]
        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un montant")]
        public int Montant { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Date finale")]
        public DateTime? DevisDateFinale { get; set; }

        [Range(1, Int64.MaxValue, ErrorMessage = "Montant positif attendu")]
        [Display(Name = "Montant final")]
        public int? MontantFinal { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez renseigner une mission")]
        [ForeignKey("Mission")]
        [Display(Name = "N° Mission")]
        public int MissionId { get; set; }

        public virtual Mission Mission { get; set; }
    }
}
