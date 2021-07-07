using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CENProject.Models
{
    public class Review
    {
        public int ReviewID { get; set; }
        public int PaperID { get; set; }
        public int ReviewerID { get; set; }
        [Display(Name = "Appropriateness of Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float AOT { get; set; }
        [Display(Name = "Timeliness of Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float ToT { get; set; }
        [Display(Name = "Supportive Evidence")]
        [Column(TypeName = "decimal(3,2)")]
        public float SE { get; set; }
        [Display(Name = "Technical Quality")]
        [Column(TypeName = "decimal(3,2)")]
        public float TQ { get; set; }
        [Display(Name = "Scope of Coverage")]
        [Column(TypeName = "decimal(3,2)")]
        public float SoC { get; set; }
        [Display(Name = "Citation of Previous Work")]
        [Column(TypeName = "decimal(3,2)")]
        public float CoPW { get; set; }

        [Column(TypeName = "decimal(3,2)")]
        public float Originality { get; set; }
        [Display(Name = "Content Comments")]
        [StringLength(int.MaxValue)]
        public string CC { get; set; }
        [Display(Name = "Organization of Paper")]
        [Column(TypeName = "decimal(3,2)")]
        public float OoP { get; set; }
        [Display(Name = "Clarity of Main Message")]
        [Column(TypeName = "decimal(3,2)")]
        public float CoMM { get; set; }
        [Column(TypeName = "decimal(3,2)")]
        public float Mechanics { get; set; }
        [Display(Name = "Written Document Comments")]
        [StringLength(int.MaxValue)]
        public string WDC { get; set; }
        [Display(Name = "Suitability for Presentation")]
        [Column(TypeName = "decimal(3,2)")]
        public float SfP { get; set; }
        [Display(Name = "Potential Interest in Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float PIiT { get; set; }
        [Display(Name = "Potential for Oral Presentation Comments")]
        [StringLength(int.MaxValue)]
        public string PfOPC { get; set; }
        [Display(Name = "Overall Rating")]
        [Column(TypeName = "decimal(3,2)")]
        public float OR { get; set; }
        [Display(Name = "Overall Rating Comments")]
        [StringLength(int.MaxValue)]
        public string ORC { get; set; }
        [Display(Name = "Comfort Level Topic")]
        [Column(TypeName = "decimal(3,2)")]
        public float CLT { get; set; }
        [Display(Name = "Comfort Level Acceptability")]
        [Column(TypeName = "decimal(3,2)")]
        public float CLA { get; set; }
        public bool Complete { get; set; }

    }
}
