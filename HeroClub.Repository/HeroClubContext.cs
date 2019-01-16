using HeroClub.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HeroClub.Repository
{
    public class HeroClubContext : IdentityDbContext<User, Role, int, 
        IdentityUserClaim<int>, UserRole, IdentityUserLogin<int>, 
        IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public HeroClubContext(DbContextOptions<HeroClubContext> options) : base (options) { }        
        public DbSet<Batalha> Batalhas { get; set; }
        public DbSet<Citacao> Citacoes { get; set; }
        public DbSet<Equipe> Equipes { get; set; }
        public DbSet<Heroi> Herois { get; set; }
        public DbSet<EquipeHeroi> EquipeHerois { get; set; }
        public DbSet<EquipeHeroiBatalha> EquipeHeroiBatalhas { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserRole>(userRole => {
                
                userRole.HasKey(ur => new {ur.UserId, ur.RoleId});

                userRole.HasOne(ur => ur.Role)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.RoleId)
                .IsRequired();

                userRole.HasOne(ur => ur.User)
                .WithMany(r => r.UserRoles)
                .HasForeignKey(ur => ur.UserId)
                .IsRequired();
            });

            modelBuilder.Entity<EquipeHeroi>()
                .HasKey(s => new { s.EquipeId, s.HeroiId });
            
            modelBuilder.Entity<EquipeHeroiBatalha>()
                .HasKey(s => new { s.EquipeId, s.HeroiId, s.BatalhaId });
        }
    }
}