using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudyPlatform.BL.Models
{
    /// <summary>
    /// Статус назначенной лекции.
    /// </summary>
    public class LectureStatus 
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Навзание статуса.
        /// </summary>
        [Required]
        [MaxLength(20)]
        public string Name { get; set; }
        /// <summary>
        /// Ссылки на лекции с заданным статусом.
        /// </summary>
        public List<Lecture> Lectures { get; set; } = new();
        /// <summary>
        /// Создать новый статус.
        /// </summary>
        /// <param name="name"> Название статуса. </param>
        /// <exception cref="ArgumentException"> Название статуса Null или пустое.</exception>
        public LectureStatus(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название статуса не может быть Null или пустым.", nameof(name));
            }
            Name = name;
        }
    }
}