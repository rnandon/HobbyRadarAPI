using HobbyRadarAPI.Configuration;
using HobbyRadarAPI.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HobbyRadarAPI.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions options)
            :base(options)
        {

        }

        public DbSet<Hobby> Hobbies{ get; set; }
        public DbSet<Tag> Tags { get; set; }
        public DbSet<HobbyTag> HobbyTags { get; set; }
        public DbSet<ScheduledEvent> ScheduledEvents { get; set; }
        public DbSet<Connection> Connections { get; set; }
        public DbSet<UserAlert> UserAlerts { get; set; }
        public DbSet<ConnectionInvite> ConnectionInvites { get; set; }
        public DbSet<EventAttendance> EventAttendances { get; set; }
        public DbSet<UserHobby> UserHobbies { get; set; }
        public DbSet<UserHobbyRating> UserHobbyRating { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<HobbyTag>().HasKey(ht => new { ht.HobbyId, ht.TagId });
            modelBuilder.Entity<Connection>().HasKey(c => new { c.User1Id, c.User2Id });
            modelBuilder.Entity<EventAttendance>().HasKey(ea => new { ea.ScheduledEventId, ea.UserId });
            modelBuilder.Entity<UserHobby>().HasKey(uh => new { uh.UserId, uh.HobbyId });
            modelBuilder.Entity<UserHobbyRating>().HasKey(uhr => new { uhr.UserId, uhr.HobbyId });

            modelBuilder.Entity<User>()
                .HasMany(u => u.InvitesReceived)
                .WithOne("FromUser")
                .HasForeignKey("FromUserId");

            modelBuilder.Entity<User>()
                .HasMany(u => u.InvitesSent)
                .WithOne("ToUser")
                .HasForeignKey("ToUserId");

            modelBuilder.Entity<User>()
                .HasMany(u => u.Alerts)
                .WithOne("User")
                .HasForeignKey("UserId");

            modelBuilder.Entity<User>()
                .HasMany(u => u.AttendingEvents)
                .WithOne("User")
                .HasForeignKey("UserId");


            modelBuilder.ApplyConfiguration(new RolesConfiguration());
        }

    }
}