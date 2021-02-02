﻿using System.ComponentModel.DataAnnotations;

namespace Twitter.Consumer.Api.Models
{
    public record RegisterModel
    {
        [Required(ErrorMessage = "User Name is required")]
        public string Username { get; init; } = "";

        [EmailAddress]
        [Required(ErrorMessage = "Email is required")]
        public string Email { get; init; } = "";

        [Required(ErrorMessage = "Password is required")]
        public string Password { get; init; } = "";
    }
}