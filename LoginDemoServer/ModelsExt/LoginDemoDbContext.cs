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

    //public User GetUserGrades(string email)
    //{
        
    //}



















    //public Models.Users GetUSerFromDB(string email)
    //{
    //    Models.Users user = this.Users.Where(u => u.Email == email).FirstOrDefault();
    //    return user;
    //}

    //public Users GetUserGrades(string email)
    //{
    //    return Users.Include(u => u.Grades)
    //                .FirstOrDefault(u => u.Email == email);
    //}

    
    

    
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

