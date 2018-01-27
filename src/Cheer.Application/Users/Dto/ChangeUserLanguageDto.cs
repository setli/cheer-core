using System.ComponentModel.DataAnnotations;

namespace Cheer.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}