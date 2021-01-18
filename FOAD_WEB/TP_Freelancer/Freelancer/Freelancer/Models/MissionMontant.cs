using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Freelancer.Models
{
    public class MissionMontant : Mission
    {
        
        [Range (1, Int64.MaxValue, ErrorMessage = "Montant positif attendu")]
        [NotMapped]
        public int Montant { get; set; }
    }
}
