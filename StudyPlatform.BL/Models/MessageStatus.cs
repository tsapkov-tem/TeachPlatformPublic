
using System.ComponentModel.DataAnnotations;

namespace StudyPlatform.BL.Models
{
    public class MessageStatus 
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Название статуса.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Отредактировано ли сообщение.
        /// </summary>
        public bool Edit { get; set; }
        /// <summary>
        /// Создать статус сообщения.
        /// </summary>
        /// <param name="name"> Название статуса. </param>
        /// <exception cref="ArgumentException"> Название статуса пустое или Null. </exception>
        public MessageStatus(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название статуса не может быть Null или пустым.", nameof(name));
            }

            Name = name;
            Edit = false;
        }
    }
}