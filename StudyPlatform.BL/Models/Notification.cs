
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
    /// Оповещение.
    /// </summary>
    public class Notification 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Текст оповещения.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Text { get; set; }
        /// <summary>
        /// Дата появления оповещения.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
        /// <summary>
        /// Айди пользователя, которому отправлено оповещение.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        /// <summary>
        /// Ссылка на пользователя, для которого оповещение.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Проверено ли оповещение.
        /// </summary>
        [Required]
        public bool Checked { get; set; }
        /// <summary>
        /// Ссылка на объект, о котором оповещение.
        /// </summary>
        [MaxLength(200)]
        public string? Link { get; set; }

        /// <summary>
        /// Создать новое оповещение.
        /// </summary>
        /// <param name="text"> Текст оповещения. </param>
        /// <param name="idUser"> Айди пользователя, которому отправлено оповещение. </param>
        /// <param name="link"> Ссылка на объект, о котором оповещение. </param>
        public Notification(string text, int idUser, string link)
        {
            Text = text;
            Date = DateTime.Now;
            IdUser = idUser;
            Checked = false;
            Link = link;
        }
    }
}
