using System;
using System.Collections.Generic;
using System.Diagnostics;
using LoginDemoServer.DTO;
using System.Net.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LoginDemoServer.Models;

public partial class LoginDemoDbContext : DbContext
{
    public Models.Users GetUSerFromDB(string email)
    {
        Models.Users user = this.Users.Where(u => u.Email == email).FirstOrDefault();
        return user;
    }

    public Users GetUserGrades(string email)
    {
        return Users.Include(u => u.Grades)
                    .FirstOrDefault(u => u.Email == email);
    }

    public DbSet<Users> Users { get; set; }
    public DbSet<Grades> Grades { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Users>()
            .HasMany(u => u.Grades)
            .WithOne(g => g.Users)
            .HasForeignKey(g => g.UserEmail);
    }

    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new LoginDemoDbContext(
            serviceProvider.GetRequiredService<DbContextOptions<LoginDemoDbContext>>()))
        {
            if (context.Grades.Any())
            {
                return;
            }

            context.Grades.AddRange(
                new Grades
                {
                    ExamDate = DateTime.Now,
                    Subject = "Math",
                    Score = 90,
                    UserEmail = "student1@example.com"
                },
                new Grades
                {
                    ExamDate = DateTime.Now,
                    Subject = "Science",
                    Score = 85,
                    UserEmail = "student1@example.com"
                }
            );

            context.SaveChanges();
        }

        //public async Task<UserDTO> GetFullUserObject(string email)
        //{
        //    var response = await httpClient.GetAsync($"api/users/GetUserGrades?email={email}");
        //    if (response.IsSuccessStatusCode)
        //    {
        //        return await response.Content.ReadFromJsonAsync<UserDTO>();
        //    }
        //    return null;
        ////}


        //private async void OnUserDetailsButtonClicked(object sender, EventArgs e)
        //{
        //    var email = // get logged-in user email
        //    var user = await apiProxy.GetFullUserObject(email);
        //    if (user != null)
        //    {
        //        await Navigation.PushAsync(new UserDetailsPage(user));
        //    }
        //}


    }

}

