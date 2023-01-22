using System.ComponentModel.DataAnnotations;
using System.Reflection;
using System.Xml.Linq;

namespace ThesisZuordnen.Models
{
    public class Thesis
    {
        [Display(Name = "Share Bonds [%]")]
        public int id { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? Title { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? Description { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public bool Bachelor { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public bool Master { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public enum Status
        {
            Available,
            Allocated,
            Filed,
            ASubmitted,
            Graded
        }
        [Display(Name = "Share Bonds [%]")]
        public string? StudentName { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? StudentEmail { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? StudentID { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public DateTime Registration { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public DateTime Filing { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? Summary { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? Strengths { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? Weakness { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public string? Evaluation { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int ContentVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int LayoutVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int StructureVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int StyleVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int LiteratureVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int DifficultyVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int NoveltyVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int RichnessVal { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int ContentWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int LayoutWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int StructureWT { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int StyleWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int LiteratureWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int DifficultyWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int NoveltyWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public int RichnessWt { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public double Grade { get; set; }
        [Display(Name = "Share Bonds [%]")]
        public DateTime LastModified { get; set;  }
    }
}
