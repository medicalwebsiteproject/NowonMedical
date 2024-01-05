using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NowonMedical.Models
{

    [Table("AdminIPTbl")]
    public class AdminIP
    {
        [Key]
        [MaxLength(15)]
        public string ip_v4 { get; set; }
    }
}
