using DataAnnotation = System.ComponentModel.DataAnnotations;

namespace Lhg.SoccerVirtual.Backend.Models
{
    public class ApplicationUser
    {
        [DataAnnotation.Key]
        public int Id { get; set; }

        [DataAnnotation.Required]
        [DataAnnotation.MinLength(4, ErrorMessageResourceName = "NameMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(120, ErrorMessageResourceName = "NameMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string Name { get; set; }

        [DataAnnotation.Required]
        [DataAnnotation.MinLength(5, ErrorMessageResourceName = "LastNameMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(240, ErrorMessageResourceName = "LastNameMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string LastName { get; set; }

        [DataAnnotation.MinLength(4, ErrorMessageResourceName = "AliasMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(18, ErrorMessageResourceName = "AliasMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string Alias { get; set; }

        [DataAnnotation.MinLength(8, ErrorMessageResourceName = "PasswordMinLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        [DataAnnotation.MaxLength(15, ErrorMessageResourceName = "PasswordMaxLenghtError", ErrorMessageResourceType = typeof(Resources.ErrorMessages))]
        public string Password { get; set; }

        public void Update(ApplicationUser appUserToUpdate)
        {
            Name = appUserToUpdate.Name;
            LastName = appUserToUpdate.LastName;
            Alias = appUserToUpdate.Alias;
            Password = appUserToUpdate.Password;
        }

    }
}