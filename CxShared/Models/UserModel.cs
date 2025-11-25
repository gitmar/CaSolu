using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxShared.Models
{
    public class GxUser
    {
        public int Id { get; set; } = 0;
        public string Username { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string PasswordHash { get; set; } = string.Empty;
        public string Prole { get; set; } = "Support"; // default role
        public string Nom { get; set; } = string.Empty;
        public string Pnom { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Phon2 { get; set; } = string.Empty;
        public string Whatsapp { get; set; } = string.Empty;
        public List<Grole> Groles { get; set; } = new();
    }
    public class Grole
    {
        public int Id { get; set; } = 0;
        public int Userid { get; set; } = 0;
        public string Rolname { get; set; } = string.Empty;
        public int Level { get; set; } = 0;
        public string Description { get; set; } = string.Empty;
    }
}
