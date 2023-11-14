using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations; /* new add*/

namespace PatriciasBooks.Models
{
    public class CoverType
    {
        public int Id { get; set; }

        [Display(Name = "Cover Name")]
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
