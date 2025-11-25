using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxShared.Models
{
    public class Gxdom
    {
        [Key]
        public int Id { get; set; } = 0;
        public string GxRaison { get; set; } = string.Empty;
        public string GxSigle { get; set; } = string.Empty;
        public int LastIdorg { get; set; } = 10000;
        public int LastIdact { get; set; } = 0;
        public string? HlpUsername { get; set; }
        public string? HlpEmail { get; set; }
        public string? HlpWurl { get; set; }
        public string? HlpPhone { get; set; }
        public string? HlpPhon2 { get; set; }
        public int Ipays { get; set; } = 0;
        public int Pmeth { get; set; } = 0;
        public int Eta { get; set; } = 0;
        public string Obsv { get; set; } = string.Empty;

        //// Navigation
        public List<Agent> Agents { get; set; } = new();
    }
    public class Agent
    {
        [Key]
        public int Id { get; set; } = 0;
        public int Idgx { get; set; } = 0;
        [ForeignKey(nameof(Idgx))]
        public Gxdom? Gxdom { get; set; }
        public int UsrId { get; set; } = 0;
        public string Username { get; set; } = string.Empty;
        //public string UsernameOrEmail { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Pnom { get; set; } = string.Empty;
        public int Role { get; set; } = 0;
        public int Eta { get; set; } = 1;
        public string Obsv { get; set; } = string.Empty;
        // Navigation
        public List<Gxact> Gxacts { get; set; } = new();
    }
    public class Gxact
    {
        [Key]
        public int Id { get; set; } = 0;
        public int Idagt { get; set; } = 0;
        [ForeignKey(nameof(Idagt))]
        public Agent Agent { get; set; } = null!;
        public int Optyp { get; set; } = 0;
        public DateTime Ddate { get; set; } = DateTime.Now;
        public DateTime Fdate { get; set; } = new DateTime();
        public decimal Value { get; set; } = 0;
        public bool Si { get; set; } = false;
        public int Eta { get; set; } = 1;
        public string Obsv { get; set; } = string.Empty;
        // Navigation
        public List<Actlne> Actionlines { get; set; } = new();
    }
    public class Actlne
    {
        [Key]
        public int Id { get; set; }
        public int Idact { get; set; } = 0;
        [ForeignKey(nameof(Idact))]
        public Gxact? Gxact { get; set; }
        public int Idope { get; set; } = 0;
        public DateTime Ddate { get; set; } = DateTime.Now;
        public DateTime Fdate { get; set; } = new DateTime();
        public decimal Value { get; set; } = 0;
        public bool Si { get; set; } = false;
        public int Eta { get; set; } = 1;
        public string Obsv { get; set; } = string.Empty;
    }
}