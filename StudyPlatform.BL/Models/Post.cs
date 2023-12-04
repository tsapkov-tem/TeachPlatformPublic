
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPlatform.BL.Models
{
    /// <summary>
    /// Пост в чате группы.
    /// </summary>
    public class Post 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Текст поста.
        /// </summary>
        [Required]
        private string description;
        public required string Description {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Текст поста не может быть Null или пустым.");
                }
                if(value.Length > 2000)
                {
                    throw new ArgumentException("Текст поста не может быть больше 2000 символов");
                }
                description = value;
            }
            get { return description; }
        }
        /// <summary>
        /// Айди пользователя, написавшего пост.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        /// <summary>
        /// Дата написания поста.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
        /// <summary>
        /// Айди группового чата, в котором написан пост.
        /// </summary>
        [Required]
        public int IdGroupChat { get; set; }
        /// <summary>
        /// Ссылка на групповой чат, в котором написан пост.
        /// </summary>
        public GroupChat GroupChat { get; set; }
        /// <summary>
        /// Ссылка на файлы приложенные в пост.
        /// </summary>
        public IList<Files> Files { get; set; }

        /// <summary>
        /// Создать новый пост.
        /// </summary>
        /// <param name="description"> Текст поста. </param>
        /// <param name="idUser"> Айди пользователя, написавшего пост. </param>
        /// <param name="idGroupChat"> Айди группового чата, в котором написан пост. </param>
        public Post(string description, int idUser, int idGroupChat)
        {
            Description = description;
            IdUser = idUser;
            Date = DateTime.Now;
            IdGroupChat = idGroupChat;
        }
    }
}
