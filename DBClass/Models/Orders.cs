using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClass.Models
{
    [Table("Orders")]
    public class Orders
    {
        [Key]
        public int Id { get; set; }
        public int UserId { get; set; }

        [Required]
        public string ReceiverAddress { get; set; }
        public string ReceiverEmail { get; set; }
        public string ReceiverPhone { get; set; }

        public string Note { get; set; }

        [Required]
        public DateTime CreateAt { get; set; }
        public string UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }


    }
}
