using System;
using System.ComponentModel.DataAnnotations;

namespace TheBridalStore.WebApi.Models
{
    public class AuthenticateModel
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }
}
