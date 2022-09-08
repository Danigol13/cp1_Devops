using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace CarWeb.Models
{
    public class Login
    {
        public String Email{ get; set; } = "HybridInnovation@fiap.com";
        public string Senha { get; set; } = "fiap@123";

    }
}