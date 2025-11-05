using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxShared.Models
{
    //support
    //public class GxdomDto
    //{
    //    [Key]
    //    public int Id { get; set; } = 0;
    //    public string GxRaison { get; set; } = string.Empty;
    //    public string GxSigle { get; set; } = string.Empty;
    //    public int LastIdorg { get; set; } = 0;
    //    public int LastIdact { get; set; } = 0;
    //    public int Eta { get; set; } = 0;
    //    // Navigation property
    //    public List<AgentDto> Agents { get; set; } = new();
    //    public string Obsv { get; set; } = string.Empty;
    //}
    //public class AgentDto
    //{
    //    [Key]
    //    public int Id { get; set; } = 0;
    //    [ForeignKey("Gxdom")]
    //    public int Idgx { get; set; } = 0; // Foreign key
    //    public string Usrname { get; set; } = string.Empty;
    //    public int UsrId { get; set; } = 0;
    //    public string Nom { get; set; } = string.Empty;
    //    public string Pnom { get; set; } = string.Empty;
    //    public int Role { get; set; } = 0;
    //    public int Eta { get; set; } = 1;
    //    // Navigation back to Gxdom
    //    public GxdomDto? Gxdom { get; set; }
    //    // Navigation property
    //    public List<ActionDto> Actions { get; set; } = new();
    //    public string Obsv { get; set; } = string.Empty;
    //}
    //public class ActionDto
    //{
    //    [Key]
    //    public int Id { get; set; } = 0;
    //    [ForeignKey("Agent")]
    //    public int Idagt { get; set; } = 0; // Foreign key
    //    public int Optyp { get; set; } = 0;
    //    public DateTime Ddate { get; set; } = DateTime.Now;
    //    public DateTime Fdate { get; set; } = new DateTime();
    //    public decimal Value { get; set; } = 0;
    //    public bool Si { get; set; } = false;
    //    public int Eta { get; set; } = 1;
    //    // Navigation back to Agent
    //    public AgentDto Agent { get; set; } = null!;
    //    public List<ActlneDto> Actionlines { get; set; } = new();
    //    public string Obsv { get; set; } = string.Empty;
    //}
    //public class ActlneDto
    //{
    //    [Key]
    //    public int Id { get; set; }  // Primary key
    //    [ForeignKey("Action")]
    //    public int Idact { get; set; } = 0; // Foreign key
    //    public int Idope { get; set; } = 0;
    //    public DateTime Ddate { get; set; } = DateTime.Now;
    //    public DateTime Fdate { get; set; } = new DateTime();
    //    public decimal Value { get; set; } = 0;
    //    public bool Si { get; set; } = false;
    //    public int Eta { get; set; } = 1;
    //    // Navigation back to Action
    //    public ActionDto? Action { get; set; }
    //    public string Obsv { get; set; } = string.Empty;
    //}

    public class Gxdom
    {
        [Key]
        public int Id { get; set; } = 0;

        public string GxRaison { get; set; } = string.Empty;
        public string GxSigle { get; set; } = string.Empty;
        public int LastIdorg { get; set; } = 0;
        public int LastIdact { get; set; } = 0;
        public int Eta { get; set; } = 0;
        public string Obsv { get; set; } = string.Empty;

        // Navigation
        public List<Agent> Agents { get; set; } = new();
    }
    public class Agent
    {
        [Key]
        public int Id { get; set; } = 0;

        public int Idgx { get; set; } = 0;

        [ForeignKey(nameof(Idgx))]
        public Gxdom? Gxdom { get; set; }

        public string Usrname { get; set; } = string.Empty;
        public int UsrId { get; set; } = 0;
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