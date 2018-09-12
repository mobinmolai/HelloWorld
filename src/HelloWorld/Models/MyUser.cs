using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System;

namespace HelloWorld.Models
{
    public class MyUser: IdentityUser
    {
        public DateTime FirstTrip { get; set; }
    }
}