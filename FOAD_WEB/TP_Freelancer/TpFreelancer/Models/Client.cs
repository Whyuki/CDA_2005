using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TpFreelancer.Models
{
    [Table("clients")]
    public class Client
    {
        [Column("client_id")]
        [Key]
        public int ClientId { get; set; }

        [Required]
        [StringLength(25)]
        public string Nom { get; set; }

        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
    }
}
