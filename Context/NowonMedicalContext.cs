using Microsoft.EntityFrameworkCore;
using NowonMedical.Models;

namespace NowonMedical.Context
{
    public class NowonMedicalContext : DbContext
    {

        public NowonMedicalContext(DbContextOptions<NowonMedicalContext> options) : base(options) { }

        public DbSet<AdminIP> adminIPs { get; set; }
        public DbSet<CommunityBoard> communityBoards { get; set; } 
        public DbSet<BoardMedia> boardMedia { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminIP>().ToTable("AdminIPTbl");
            modelBuilder.Entity<CommunityBoard>().ToTable("CommunityBoardTbl", b => b.HasCheckConstraint("CK_BoardType", "[Type] in ('Notice', 'News', 'Review')")).HasMany(e => e.Media).WithOne(e => e.CommunityBoard).HasForeignKey(e => e.BoardId);
            modelBuilder.Entity<BoardMedia>().ToTable("BoardMediaTbl", b => b.HasCheckConstraint("CK_MediaType", "[MediaType] in ('Image', 'Video', 'File')")).HasOne(e => e.CommunityBoard).WithMany(e => e.Media).HasForeignKey(e => e.BoardId);
        }
    }
}
