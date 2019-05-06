using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Benedicta.Models
{
    public class Reservation
    {
        public int Id { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        [StringLength(200)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        public DateTimeOffset Time { get; set; } //burda deqiq bilmirem time'in type'ini

        [Column(TypeName = "date")]
        public DateTime Date { get; set; }

        public int Seats { get; set; }

        [Column(TypeName = "ntext")]
        public string SpecialRequests { get; set; }
    }
}