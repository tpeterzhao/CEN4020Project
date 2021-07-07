using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CENProject.Models
{
    public class Paper
    {
        public int PaperID { get; set; }
        public int AuthorID { get; set; }
        public bool Active { get; set; }
        [StringLength(100), Required]
        public string FilenameOriginal { get; set; }
        [StringLength(100), Required]
        public string Filename { get; set; }
        [StringLength(200), Required]
        public string Title { get; set; }
        [StringLength(3), Required]
        public string Certification { get; set; }
        [StringLength(int.MaxValue)]
        public string NotesToReviewers { get; set; }
        [Display(Name = "Analysis of Algorithms")]
        public bool AoA { get; set; }
        public bool Applications { get; set; }
        public bool Architecture { get; set; }
        [Display(Name = "Artificial Intelligence")]
        public bool AI { get; set; }
        [Display(Name = "Computer Engineering")]
        public bool CE { get; set; }
        public bool Curriculum { get; set; }
        [Display(Name = "Data Structure")]
        public bool DS { get; set; }
        public bool Database { get; set; }
        [Display(Name = "Distance Learning")]
        public bool DL { get; set; }
        [Display(Name = "Distributed Systems")]
        public bool DSS { get; set; }
        [Display(Name = "Ethical Societal Issues")]
        public bool ESI { get; set; }
        [Display(Name = "First Year Computing")]
        public bool FYC { get; set; }
        [Display(Name = "Gender Issues")]
        public bool GI { get; set; }
        [Display(Name = "Grant Writing")]
        public bool GW { get; set; }
        [Display(Name = "Graphics Image Processing")]
        public bool GIP { get; set; }
        [Display(Name = "Human Computer Interaction")]
        public bool HCI { get; set; }
        [Display(Name = "Laboratory Environments")]
        public bool LE { get; set; }
        public bool Literacy { get; set; }
        [Display(Name = "Mathematics In Computing")]
        public bool MIC { get; set; }
        public bool Multimedia { get; set; }
        [Display(Name = "Networking Data Communication")]
        public bool NDC { get; set; }
        [Display(Name = "Non Major Courses")]
        public bool NMC { get; set; }
        [Display(Name = "Object Oriented Issues")]
        public bool OOI { get; set; }
        [Display(Name = "Operating Systems")]
        public bool OS { get; set; }
        [Display(Name = "Parallel Processing")]
        public bool PP { get; set; }
        public bool Pedagogy { get; set; }
        [Display(Name = "Programming Languages")]
        public bool PL { get; set; }
        public bool Research { get; set; }
        public bool Security { get; set; }
        [Display(Name = "Software Engineering")]
        public bool SE { get; set; }
        [Display(Name = "System Analysis And Design")]
        public bool SAAD { get; set; }
        [Display(Name = "Using Technology In The Classroom")]
        public bool UTITC { get; set; }
        [Display(Name = "Web And Internet Programming")]
        public bool WAIP { get; set; }
        public bool Other { get; set; }
        [Display(Name = "Other Description")]
        [StringLength(50)]
        public string OD { get; set; }



    }
}
