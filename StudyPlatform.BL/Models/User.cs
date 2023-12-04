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
    /// Класс пользователя.
    /// </summary>
    public class User 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Имя пользователя.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Firstname { get; set; }
        /// <summary>
        /// Фамилия пользователя.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Secondname { get; set; }
        /// <summary>
        /// Отчетсво пользователя.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Fathername { get; set; }
        /// <summary>
        /// Сссылки на домашние работы, сданные пользователем.
        /// </summary>
        //public List<Homework> Homework { get; set; } = new();
        ///// <summary>
        ///// Ссылки на оповещения, для пользователя.
        ///// </summary>
        //public List<Notification> Notifications { get; set; } = new();
        ///// <summary>
        ///// Полное имя пользователя: Firstname + Secondname + Fathername
        ///// </summary>
        //public string Fullname { get { return Firstname + " " + Secondname + " " + Fathername; } }
        ///// <summary>
        ///// Ссылки на чаты, в которых находится пользователь.
        ///// </summary>
        //public List<Chat> Chats { get; set; } = new();
        ///// <summary>
        ///// Ссылки на строки в таблицу связей пользователей и групп.
        ///// </summary>
        //public List<GroupedUsers> GroupedUsers { get; set; } = new(); 

        /// <summary>
        /// Создать нового пользователя.
        /// </summary>
        /// <param name="firstname"> Имя пользователя. </param>
        /// <param name="secondname"> Фамилия пользователя. </param>
        /// <param name="fathername"> Отчество пользователя. </param>
        /// <param name="authUser"> Данные для аутендификации пользователя. </param>
        /// <exception cref="ArgumentException"> Один из аргументов пустой или Null. </exception>
        public User(string firstname, 
            string secondname,
            string fathername = "")
        {
            if (string.IsNullOrWhiteSpace(firstname))
            {
                throw new ArgumentException("Имя пользователя не может быть Null или пустым.", nameof(firstname));
            }

            if (string.IsNullOrWhiteSpace(secondname))
            {
                throw new ArgumentException("Фамилия пользователя не может быть Null или пустым.", nameof(secondname));
            }

            Firstname = firstname;
            Secondname = secondname;
            Fathername = fathername;
        }
    }
}
