using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NowonMedical.Models
{

    [Table("CommunityBoardTbl")]
    public class CommunityBoard 
    {
        [Key]
        [Required]
        public int BoardId { get; set; }

        [Required]
        [MaxLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [Required]
        public string Type { get; set; }

        [Required]
        public DateTime Created { get; set; } = DateTime.Now;

        public IList<BoardMedia>? Media { get; }
    }
}
