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

        [Required]
        [StringLength(10)]
        public char Etat { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [Required]
        public int Montant { get; set; }

        [DataType(DataType.Date)]
        public DateTime DevisDateFinale { get; set; }

        public int MontantFinal { get; set; }

        [Required]
        [ForeignKey("Mission")]
        public int MissionId { get; set; }

    }
}
