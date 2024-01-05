using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NowonMedical.Models
{

    [Table("BoardMediaTbl")]
    public class BoardMedia
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Display(Name = "CommunityBoard")]
        public int BoardId { get; set; }

        [ForeignKey("BoardId")]
        public virtual CommunityBoard CommunityBoard { get; set; }
        
        [Required]
        public string MediaPath { get; set; }

        [Required]
        public string MediaType { get; set; }
    }
}
