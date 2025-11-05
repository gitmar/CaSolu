using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CxShared.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Runtime.InteropServices;
    //IValidatableObject
    //public class CustomerDto
    //{
    //    [Key]
    //    public int Id { get; set; }
    //    public int Cdeid {  get; set; } = 0; //replique le Id
    //    public string Idstr { get; set; } = string.Empty;
    //    public int Iqmax { get; set; } = 0;
    //    public int Gdom { get; set; } = 0;
    //    public string Nom { get; set; } = string.Empty;
    //    public string Pnom { get; set; } = string.Empty;
    //    public string Email { get; set; } = string.Empty;
    //    public string Username { get; set; } = string.Empty;
    //    public string UsernameOrEmail { get; set; } = string.Empty;
    //    public string Password { get; set; } = string.Empty;
    //    public string Phonenumber { get; set; } = string.Empty;
    //    public string Phon2 { get; set; } = string.Empty;
    //    public string Whatsapp { get; set; } = string.Empty;
    //    public string Role { get; set; } = string.Empty;
    //    public int Iwurl { get; set; } = 0;
    //    public string? Weburl { get; set; }
    //    public int Ishare { get; set; } = 0;
    //    public int Ipays { get; set; } = 0;
    //    public int Ilang { get; set; } = 0;
    //    public int Eta { get; set; } = 1;
    //    public int Et2 { get; set; } = 0;
    //    public List<OrderDto> Orders { get; set; } = new();
    //    public string? Obsv { get; set; }
    //    //for UI use only
    //    [NotMapped]
    //    public bool EnableEmailValidation { get; set; } = false;
    //    [NotMapped]
    //    public bool EnablePseudoValidation { get; set; } = false;
    //    [NotMapped]
    //    public bool EnablePhoneValidation { get; set; } = false;
    //    public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
    //    {
    //        if (EnableEmailValidation)
    //        {
    //            if (string.IsNullOrWhiteSpace(Email))
    //            {
    //                yield return new ValidationResult("Email is required.", new[] { nameof(Email) });
    //            }
    //            else if (!new EmailAddressAttribute().IsValid(Email))
    //            {
    //                yield return new ValidationResult("Invalid email address.", new[] { nameof(Email) });
    //            }
    //        }
    //        if (EnablePseudoValidation)
    //        {
    //            // Username validation: Letters A-Z (either case) and digits 1-9, 7 to 15 chars, no spaces
    //            if (!string.IsNullOrEmpty(Username))
    //            {
    //                var usernamePattern = @"^[A-Za-z1-9]{7,15}$";
    //                if (!Regex.IsMatch(Username, usernamePattern))
    //                {
    //                    yield return new ValidationResult("Username must be 7-15 characters long and contain only letters A-Z and digits 1-9 without spaces.", new[] { nameof(Username) });
    //                }
    //            }
    //        }
    //        if (EnablePhoneValidation)
    //        {
    //            // Example phone number validation - customize as needed
    //            if (!string.IsNullOrEmpty(Phonenumber))
    //            {
    //                var phonePattern = @"^\+?\d{7,15}$"; // allows optional + and 7-15 digits
    //                if (!Regex.IsMatch(Phonenumber, phonePattern))
    //                {
    //                    yield return new ValidationResult("Phonenumber must be between 7 and 15 digits and may start with a '+'.", new[] { nameof(Phonenumber) });
    //                }
    //            }
    //        }
    //    }
    //}
    //public class OrderDto
    //{
    //    [Key]
    //    public int Id { get; set; }  // Primary key
    //    public int Ordid { get; set; } = 0; //replique le Id
    //    [ForeignKey("Customer")]
    //    public int Idclie { get; set; } = 0; // Foreign key
    //    public string OIdstr { get; set; } = string.Empty;
    //    public DateTime Cdate { get; set; } = DateTime.Now;
    //    public DateTime Endate { get; set; } = new DateTime();
    //    public string Datstr { get; set; } = string.Empty;
    //    public int Doma { get; set; } = 0;
    //    public int Country { get; set; } = 0;
    //    public int Pack { get; set; } = 0;
    //    public int Pmeth { get; set; } = 0;
    //    public string? Raison { get; set; }
    //    public string? Sigle { get; set; }
    //    public int Oolne { get; set; } = 0;
    //    //public int Wcountry { get; set; } = 0;
    //    //public string? Weburl { get; set; }
    //    public string? Codinvit { get; set; }
    //    public int Step { get; set; } = 0;
    //    public int Idorg { get; set; } = 0;
    //    public int Olang { get; set; } = 0;
    //    public int Stp2 { get; set; } = 0;
    //    public DateTime Odate { get; set; } = DateTime.Now;
    //    // Navigation back to Customer
    //    public CustomerDto? Customer { get; set; }
    //    public string Obsv { get; set; } = string.Empty;
    //    //for UI use only
    //    [NotMapped]
    //    public string StrDate => Cdate.ToString("yyyyMMddHH");
    //    [NotMapped]
    //    public bool IsReg => Step >= (int)OrderStep.Registered;
    //    [NotMapped]
    //    public bool IsSet => Step >= (int)OrderStep.Set;
    //    [NotMapped]
    //    public bool IsArc => Step >= (int)OrderStep.Archived;
    //}
    ////UI set collections
    //public class CatgpDto
    //{
    //    public int Id { get; set; } = 0;
    //    public string Gplabel { get; set; } = string.Empty; // e.g., "Langues", "Sites", etc.
    //    public string Abg {  get; set; } = string.Empty;
    //    // A collection navigation property
    //    public ICollection<CatitemDto> Catitems { get; set; } = new List<CatitemDto>();
    //}

    //public class CatitemDto
    //{
    //    [Key]
    //    public int Id { get; set; } = 0;
    //    [ForeignKey("Catgp")]
    //    public int Idgp { get; set; } = 0;
    //    public int Elea { get; set; } = 0;
    //    public string Liba { get; set; } = string.Empty;
    //    public string Abg { get; set; } = string.Empty;
    //    // A reference navigation property
    //    public CatgpDto Catgp { get; set; } = new();
    //}

    
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        public int Cdeid { get; set; } = 0;
        public string Idstr { get; set; } = string.Empty;
        public int Iqmax { get; set; } = 0;
        public int Gdom { get; set; } = 0;
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
        public int Ipays { get; set; } = 0;
        public int Ilang { get; set; } = 0;
        public int Eta { get; set; } = 1;
        public int Et2 { get; set; } = 0;
        public string? Obsv { get; set; }

        // Navigation
        public List<Order> Orders { get; set; } = new();

        // UI flags
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

        public string OIdstr { get; set; } = string.Empty;
        public DateTime Cdate { get; set; } = DateTime.Now;
        public DateTime Endate { get; set; } = new DateTime();
        public string Datstr { get; set; } = string.Empty;
        public int Doma { get; set; } = 0;
        public int Country { get; set; } = 0;
        public int Pack { get; set; } = 0;
        public int Pmeth { get; set; } = 0;
        public string? Raison { get; set; }
        public string? Sigle { get; set; }
        public int Oolne { get; set; } = 0;
        public string? Codinvit { get; set; }
        public int Step { get; set; } = 0;
        public int Idorg { get; set; } = 0;
        public int Olang { get; set; } = 0;
        public int Stp2 { get; set; } = 0;
        public DateTime Odate { get; set; } = DateTime.Now;
        public string Obsv { get; set; } = string.Empty;

        // UI flags
        [NotMapped] public string StrDate => Cdate.ToString("yyyyMMddHH");
        [NotMapped] public bool IsReg => Step >= (int)OrderStep.Registered;
        [NotMapped] public bool IsSet => Step >= (int)OrderStep.Set;
        [NotMapped] public bool IsArc => Step >= (int)OrderStep.Archived;
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
    public enum OrderStep
    {
        Draft = 0,
        Registered = 2,
        Set = 5,
        Archived = 9
    }
}
