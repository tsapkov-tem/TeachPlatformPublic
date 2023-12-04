
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
    /// Комментарий к посту.
    /// </summary>
    public class Comment 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Текст комментария.
        /// </summary>
        private string text;
        public required string Text
        {
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Текст комментария не может быть Null или пустым.");
                }
                if(value.Length > 2000)
                {
                    throw new ArgumentException("Текст комментария превышает 2000 символов.");
                }
                text = value;
            }
            get { return text; }
        }
        /// <summary>
        /// Дата написания комментария.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
        /// <summary>
        /// Айди поста, к которому оставлен комментарий.
        /// </summary>
        [Required]
        public int IdPost { get; set; }
        /// <summary>
        /// Ссылка на пост, в котором оставлен комментарий.
        /// </summary>
        public Post Post { get; set; }
        /// <summary>
        /// Айди пользователя, написавшего комментарий.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        /// <summary>
        /// Ссылка на пользователя, написавшего пост.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Ссылка на файлы приложенные в комметнарий.
        /// </summary>
        public IList<Files> Files { get; set; }

        /// <summary>
        /// Создать новый комментарий.
        /// </summary>
        /// <param name="text"> Текст комментария. </param>
        /// <param name="idPost"> Айди поста, к которому написан комментарий. </param>
        /// <param name="idUser"> Айди пользователя, написавшего комментарий. </param>
        public Comment(string text, int idPost, int idUser)
        {
            Text = text;
            Date = DateTime.Now;
            IdPost = idPost;
            IdUser = idUser;
        }
    }
}
