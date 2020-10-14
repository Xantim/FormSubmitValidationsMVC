using System.ComponentModel.DataAnnotations;

namespace AS_FormSubmission.Models
{
    public class User
    {
        [Required]
        [MinLength(2,ErrorMessage="you need 2 characters yo!")]
        public string FirstName {get;set;}
        
        [Required]
        [MinLength(2)]
        public string LastName {get;set;}
        
        [Required]
        [Range(1,100)]
        public int Age {get;set;}
        
        [Required]
        [EmailAddress]
        public string Email {get;set;}

        [Required]
        [MinLength(6)]
        [DataType(DataType.Password)]
        public string Password {get;set;}

    }
}