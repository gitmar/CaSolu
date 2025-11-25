using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxShared.Models
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.InteropServices;
    using System.Text.Json.Serialization;
    using System.Text.RegularExpressions;

    //IValidatableObject
    
    public class Customer
    {
        [Key]
        public int Id { get; set; }
        public int Cdeid { get; set; } = 0;
        public string Idstr { get; set; } = string.Empty;
        public int Iqmax { get; set; } = 0;
        public int Idorg { get; set; } = 0;
        public string Nom { get; set; } = string.Empty;
        public string Pnom { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string UsernameOrEmail { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Phonenumber { get; set; } = string.Empty;
        public string Phon2 { get; set; } = string.Empty;
        public string Whatsapp { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int Iwurl { get; set; } = 0;
        public string? Weburl { get; set; }
        public int Ishare { get; set; } = 0;
        public int Idoma { get; set; } = 0;
        public int Jdoma { get; set; } = 0;
        public string? Sidom { get; set; }
        public string? Sjdom { get; set; }
        public int Pack { get; set; } = 0;
        public int Pmeth { get; set; } = 0;
        public string? Raison { get; set; }
        public string? Sigle { get; set; }
        public int Ipays { get; set; } = 0;
        public int Ilang { get; set; } = 0;
        public int Eta { get; set; } = 1;
        public int Et2 { get; set; } = 0;
        //public string? Codinvit { get; set; }
        public string? HlpEmail { get; set; } //support email
        public string? HlpWurl { get; set; }  //support siteweb
        public string? HlpPhone { get; set; } //support phone
        public string? HlpPhon2 { get; set; } //support phon2
        public string? HlpSrole { get; set; } //support Srole
        public string? HlpUname { get; set; } //support username
        public string? Obsv { get; set; }

        //// Navigation
        //public List<Order> Orders { get; set; } = new();

        // UI flags
        [NotMapped] public bool IsDraft => Eta >= (int)CustState.Draft;
        [NotMapped] public bool IsReg => Eta >= (int)CustState.Registered;
        [NotMapped] public bool IsSet => Eta >= (int)CustState.Set;
        [NotMapped] public bool IsNotif => Eta >= (int)CustState.Notified;
        [NotMapped] public bool IsArc => Eta >= (int)CustState.Archived;
        [NotMapped] public bool IsDel => Eta >= (int)CustState.Deleted;
        [NotMapped] public bool EnableEmailValidation { get; set; } = false;
        [NotMapped] public bool EnablePseudoValidation { get; set; } = false;
        [NotMapped] public bool EnablePhoneValidation { get; set; } = false;

        // Validation logic
        public IEnumerable<ValidationResult> Validate(ValidationContext context)
        {
            if (EnableEmailValidation)
            {
                if (string.IsNullOrWhiteSpace(Email))
                    yield return new ValidationResult("Email is required.", new[] { nameof(Email) });
                else if (!new EmailAddressAttribute().IsValid(Email))
                    yield return new ValidationResult("Invalid email address.", new[] { nameof(Email) });
            }

            if (EnablePseudoValidation && !string.IsNullOrEmpty(Username))
            {
                var pattern = @"^[A-Za-z1-9]{7,15}$";
                if (!Regex.IsMatch(Username, pattern))
                    yield return new ValidationResult("Username must be 7–15 characters, A-Z and digits 1–9.", new[] { nameof(Username) });
            }

            if (EnablePhoneValidation && !string.IsNullOrEmpty(Phonenumber))
            {
                var pattern = @"^\+?\d{7,15}$";
                if (!Regex.IsMatch(Phonenumber, pattern))
                    yield return new ValidationResult("Phonenumber must be 7–15 digits and may start with '+'.", new[] { nameof(Phonenumber) });
            }
        }
    }
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public int Ordid { get; set; } = 0;
        public int Idclie { get; set; } = 0;
        [ForeignKey(nameof(Idclie))]
        public Customer? Customer { get; set; }
        public int Orang { get; set; } = 0;
        public string OIdstr { get; set; } = string.Empty;
        public DateTime Cdate { get; set; } = DateTime.Now;
        public DateTime Endate { get; set; } = new DateTime();
        public string Datstr { get; set; } = string.Empty;
        public int Opack { get; set; } = 0;
        public int Opmeth { get; set; } = 0;
        public int Step { get; set; } = 0;
        public int Oidorg { get; set; } = 0;
        public int Olang { get; set; } = 0;
        public int Stp2 { get; set; } = 0;
        public string? OCdinvit { get; set; }
        public DateTime Odate { get; set; } = DateTime.Now;
        public string Obsv { get; set; } = string.Empty;

        // UI flags
        [NotMapped]
        public string FullName => $"{Customer?.Nom} - {Customer?.Pnom}";
        [NotMapped]
        public string Weburl => $"{Customer?.Weburl}";
        [NotMapped] public string StrDate => Cdate.ToString("yyyyMMddHH");
        [NotMapped] public bool IsDraft => Step >= (int)OrderState.Draft;
        [NotMapped] public bool IsReg => Step >= (int)OrderState.Registered;
        [NotMapped] public bool IsSet => Step >= (int)OrderState.Set;
        [NotMapped] public bool IsNotif => Step >= (int)OrderState.Notified;
        [NotMapped] public bool IsArc => Step >= (int)OrderState.Archived;
        [NotMapped] public bool IsDel => Step >= (int)OrderState.Deleted;
    }
    public class CatgpDto
    {
        [Key]
        public int Id { get; set; } = 0;
        public string Gplabel { get; set; } = string.Empty;
        public string Abg { get; set; } = string.Empty;

        public ICollection<CatitemDto> Catitems { get; set; } = new List<CatitemDto>();
    }
    public class CatitemDto
    {
        [Key]
        public int Id { get; set; } = 0;

        public int Idgp { get; set; } = 0;

        [ForeignKey(nameof(Idgp))]
        public CatgpDto Catgp { get; set; } = new();
        public int Elea { get; set; } = 0;
        public string Liba { get; set; } = string.Empty;
        public string Abg { get; set; } = string.Empty;
    }
    
    public enum OrderState
    { //Step
        Draft = 0,
        Registered = 2,
        Set = 3,
        Notified = 5,
        Archived = 7,
        Deleted = 9
    }
    public enum CustState
    { //Step
        Draft = 0,
        Registered = 2,
        Set = 3,
        Notified = 5,
        Archived = 7,
        Deleted = 9
    }
}
