using System.ComponentModel.DataAnnotations;

namespace ELAP.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}