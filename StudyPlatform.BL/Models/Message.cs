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
    /// Сообщение в чате.
    /// </summary>
    public class Message
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата написания сообщения.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
        /// <summary>
        /// Айди пользователя, написавшего сообщения.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        /// <summary>
        /// Текст сообщения.
        /// </summary>
        [Required]
        [MaxLength(1000)]
        public string Text { get; set; }
        /// <summary>
        /// Ссылка на файлы приложенные в сообщение.
        /// </summary>
        public IList<Files> Files { get; set; }
        /// <summary>
        /// Айди чата, в которое отправлено сообщение.
        /// </summary>
        [Required]
        public int IdChat { get; set; }
        /// <summary>
        /// Ссылка на чат, в котором написано сообщение.
        /// </summary>
        public Chat Chat { get; set; }
        /// <summary>
        /// Айди статуса сообщения.
        /// </summary>
        [Required]
        public int IdMessageStatus { get; set; }
        /// <summary>
        /// Ссылка на статус сообщения.
        /// </summary>
        public MessageStatus Status { get; set; }

        /// <summary>
        /// Отправить новое сообщение.
        /// </summary>
        /// <param name="idUser"> Айди пользователя, отправившего сообщение. </param>
        /// <param name="text"> Текст сообщения. </param>
        /// <param name="idMessageStatus"> Айди статуса сообщения. </param>
        /// <param name="idChat"> Айди чата, в котором написано сообщение. </param>
        /// <exception cref="ArgumentException"> Теск сообщения пустой или Null. </exception>
        public Message(int idUser, string text, int idChat, int idMessageStatus)
        {
            // TODO:
            if (string.IsNullOrWhiteSpace(text))
            {
                throw new ArgumentException("Текст сообщения не может быть Null или пустым.", nameof(text)); ;
            }

            Date = DateTime.Now;
            IdMessageStatus = idMessageStatus;
            IdUser = idUser;
            Text = text;
            IdChat = idChat;
        }
    }
}
