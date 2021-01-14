using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Freelancer.Models
{
    public class Mission
    {
        [Column("mission_id")]
        [Key]
        public int MissionId { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un état")]
        //[Index(IsUnique = true)]
        [StringLength(10)]
        public string Etat { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez saisir un titre")]
        [MaxLength(100)]
        public string Titre { get; set; }

        [DataType(DataType.Date)]
        public string Debut { get; set; }

        [DataType(DataType.Date)]
        public string Fin { get; set; }

        [DataType(DataType.Text)]
        public string Description { get; set; }

        [Required(ErrorMessage = "Champ obligatoire : veuillez renseigner un client")]
        [ForeignKey("Client")]
        public int ClientId { get; set; }
    }
}
