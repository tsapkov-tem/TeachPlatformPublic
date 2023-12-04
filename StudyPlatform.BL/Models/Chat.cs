
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPlatform.BL.Models
{
    /// <summary>
    /// Чат пользователей.
    /// </summary>
    public class Chat 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название чата.
        /// </summary>
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        /// <summary>
        /// Является ли чат личным.
        /// </summary>
        [Required]
        public bool PersonalChat { get; private set; }
        /// <summary>
        /// Ссылки на сообщения в чате.
        /// </summary>
        public List<Message> Messages { get; set; } = new();
        /// <summary>
        /// Пользователи в чате.
        /// </summary>
        public List<User> Users { get; set; } = new();
        /// <summary>
        /// Создать новый чат.
        /// </summary>
        /// <param name="name"> Название чата. </param>
        /// <param name="personalChat"> Является ли чат личным. </param>
        /// <exception cref="ArgumentException"> Название группового чата Null или пустое. </exception>
        public Chat(string? name, bool personalChat)
        {
            if(!personalChat && string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название группового чата не может быть Null или пустым");
            }
            Name = name;
            PersonalChat = personalChat;
        }
    }
}
