using Microsoft.EntityFrameworkCore;

namespace MedBaseApp.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Hospital> hospitals { get; set; }
       
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        



            string adminRoleName = "admin";
            string userRoleName = "user";

            string adminEmail = "adminbekzat@gmail.ru";
            string adminFirstName = "Bekzat";
            string adminLastName = "Nauryzbayev";
            string adminPassword = "123456";
            string hospitalName = "SEMA Hospital";


            
            Role adminRole = new Role { RoleId = 1, Name = adminRoleName };
            Role userRole = new Role { RoleId = 2, Name = userRoleName };
            User adminUser = new User { UserId = 1, Email = adminEmail, FistName = adminFirstName , LastName = adminLastName,Password = adminPassword, RoleId = adminRole.RoleId };
            Hospital hospital1 = new Hospital {HospitalName = hospitalName };
            modelBuilder.Entity<Role>().HasData(new Role[] { adminRole, userRole });
            modelBuilder.Entity<User>().HasData(new User[] { adminUser });
            base.OnModelCreating(modelBuilder);

           
        





        }
    }
}