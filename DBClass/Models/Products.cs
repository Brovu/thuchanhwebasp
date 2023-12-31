﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClass.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int Id { get; set; }

        public int CateId { get; set; }

        [Required]
        public string Name { get; set; }

        public string Supplier { get; set; }


        public string Slug { get; set; }

        [Required]
        public string Detail { get; set; }

        public string Img { get; set; }

        public decimal Price { get; set; }
        public decimal DisPrice { get; set; }

        public int Qty { get; set; }

        [Required]
        public string MetaDesc { get; set; }

        [Required]
        public string MetaKey { get; set; }
        public int CreateBy { get; set; }
        public DateTime CreateAt { get; set; }
        public int UpdateBy { get; set; }
        public DateTime UpdateAt { get; set; }
        public int Status { get; set; }

    }
}
