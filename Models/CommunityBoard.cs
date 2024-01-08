using Microsoft.AspNetCore.Components.Forms.Mapping;
using System.ComponentModel;
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
        [DisplayFormat]
        public string Type { get; set; }

        [Required]
        public DateTime Created { get; set; }

        public CommunityBoard()
        {
            Created = DateTime.Now;
        }

        public IList<BoardMedia>? Media { get; }
    }
}
