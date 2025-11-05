using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace CxShared.Models
{
    public class InviteModel
    {
        public int Id { get; set; } = 0;
        public string ICoda { get; set; } = string.Empty;
        //verified by Code [Required(ErrorMessage = "You must enter a valid email address")]
        //[EmailAddress(ErrorMessage = "Invalid email address.")]
        //[DataType(DataType.EmailAddress)]
        //[Display(Name = "Email")]
        //public string Email { get; set; }

        //[Required(ErrorMessage = "You must enter a valid phone number.")]
        //[Phone(ErrorMessage = "Invalid phone number.")]
        //[DataType(DataType.PhoneNumber)]
        //[Display(Name = "Phone")]
        //public string Phonenumber { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} and at max {1} characters long.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; } = string.Empty;

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessage = "The password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; } = string.Empty;
        //[Required(ErrorMessage = "You must enter a valid Pseudo-name")]
        //[StringLength(15, ErrorMessage = "Pseudo-name cannot exceeded 15")]
        //[InvitNameValidation]
        //[InvitNameCharacterValidation]
        //[Display(Name = "Pseudo name")]
        public int Cdeid { get; set; } = 0;
        public int Ordid { get; set; } = 0;
        public string Oidstr { get; set; } = string.Empty;
        public string UsernameOrEmail { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Pseudo { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phonenumber { get; set; } = string.Empty;
        public string Usrid { get; set; } = string.Empty;
        public string Nom { get; set; } = string.Empty;
        public string Pnom { get; set; } = string.Empty;
        public int Idorg { get; set; } = 0;
        public string Raison { get; set; } = string.Empty;
        public string Sigle { get; set; } = string.Empty;
        public string Phon2 { get; set; } = string.Empty;
        public int Ipays { get; set; } = 0;
        public int Ilang { get; set; } = 0;
        public int Olang { get; set; } = 0;
        public int Imethp { get; set; } = 0;
        public int Ishare { get; set; } = 0;
        public int Idoma { get; set; } = 0;
        public string Sdoma { get; set; } = string.Empty;
        public string Scible { get; set; } = string.Empty;
        public int Gdom { get; set; } = 0;
        public int Iqmax { get; set; } = 1;
        public int Iwurl { get; set; } = 0;
        public string Swurl { get; set; } = string.Empty;
        public int Irole { get; set; } = 0;
        public string Srole { get; set; } = string.Empty; // pour verification
        public int Utyp { get; set; } = 0; //correspd a tietypn1agent2operat3client
        public bool Siowner { get; set; } = false;
        public int Dequi { get; set; } = 0;
        public int Toqui { get; set; } = 0;
        public string VndEmail { get; set; } = string.Empty; //inviter mail
        public string VndPhone { get; set; } = string.Empty; //inviter phone
        public string VndNom { get; set; } = string.Empty; //inviter username
        public string VndPnom { get; set; } = string.Empty; //inviter username
        public DateTime Datope { get; set; } = DateTime.Now;
        public string Uip { get; set; } = string.Empty; //inscrit Ip
        public string FbackUrl { get; set; } = string.Empty;
        public int Eta { get; set; } = 0;  
        public string Uadr1 { get; set; } = string.Empty;
        public string InviteLink { get; set; } = string.Empty;
        public string Obsv { get; set; } = string.Empty;
        [NotMapped]
        public bool EnableEmailValidation { get; set; } = false;
        [NotMapped]
        public bool EnablePseudoValidation { get; set; } = false;
        [NotMapped]
        public bool EnablePhoneValidation { get; set; } = false;
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            //if (EnableEmailValidation)
            //{
            //    if (string.IsNullOrWhiteSpace(Email))
            //    {
            //        yield return new ValidationResult("Email is required.", new[] { nameof(Email) });
            //    }
            //    else if (!new EmailAddressAttribute().IsValid(Email))
            //    {
            //        yield return new ValidationResult("Invalid email address.", new[] { nameof(Email) });
            //    }
            //}
            //if (EnablePseudoValidation)
            //{
            //    // Username validation: Letters A-Z (either case) and digits 1-9, 7 to 15 chars, no spaces
            //    if (!string.IsNullOrEmpty(Username))
            //    {
            //        var usernamePattern = @"^[A-Za-z1-9]{7,15}$";
            //        if (!Regex.IsMatch(Username, usernamePattern))
            //        {
            //            yield return new ValidationResult("Username must be 7-15 characters long and contain only letters A-Z and digits 1-9 without spaces.", new[] { nameof(Username) });
            //        }
            //    }
            //}
            if (EnablePhoneValidation)
            {
                // Example phone number validation - customize as needed
                if (!string.IsNullOrEmpty(Phonenumber))
                {
                    var phonePattern = @"^\+?\d{7,15}$"; // allows optional + and 7-15 digits
                    if (!Regex.IsMatch(Phonenumber, phonePattern))
                    {
                        yield return new ValidationResult("Phonenumber must be between 7 and 15 digits and may start with a '+'.", new[] { nameof(Phonenumber) });
                    }
                }
            }
        }
    }
    public class InvitNameValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value.ToString().ToLower().Contains("admin"))
            {
                return new ValidationResult("The username cannot contain the word 'admin'");
            }
            return ValidationResult.Success;
        }
    }
    //public class InvitNameCharacterValidation : ValidationAttribute
    //{
    //    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    //    {
    //        var username = value as string;
    //        if (!Regex.IsMatch(username, @"^[a-zA-Z0-9]*$"))
    //        {
    //            return new ValidationResult("Username can only contain letters and numbers.");
    //        }
    //        return ValidationResult.Success;
    //    }
    //}
}
