﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; /*new add*/

namespace PatriciasBooks.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }

        [Required]
        [Range(1, 10000)]
        public double ListPrice { get; set; }

        /*new*/
        /*[Required]
        [Range(1, 10000)]
        public double Price { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price50 { get; set; }
        [Required]
        [Range(1, 10000)]
        public double Price100 { get; set; }*/
        /**/
        public string ImageUrl { get; set; }

        [Required]
        public int CategoryId { get; set; } //foreign key reference
        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        [Required]
        public int CoverTypeId { get; set; } //foreign key reference
        [ForeignKey("CoverTypeId")]
        public CoverType CoverType { get; set; }
    }
}
