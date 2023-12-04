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
    /// Назначенная лекция.
    /// </summary>
    public class LecturePlan 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Дата проведения лекции.
        /// </summary>
        [Required]
        public DateTime Date { get; set; }
        /// <summary>
        /// Название лекции.
        /// </summary>
        [Required]
        [MaxLength(40)]
        public string Name { get; set; }
        /// <summary>
        /// Айди пользователя, ответственного за проведение лекции.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        [Required]
        ///
        public int IdLectureStatus { get; set; }
        /// <summary>
        /// Ссылка на статус назначенной лекции.
        /// </summary>
        public LectureStatus LectureStatus { get; set; }

        /// <summary>
        /// Создать новую запланированную лекцию.
        /// </summary>
        /// <param name="date"> Дата проведения лекции. </param>
        /// <param name="name"> Название лекции. </param>
        /// <param name="idUser"> Айди пользователя, ответственного за проведение лекции. </param>
        /// <param name="idLectureStatus"> Айди статуса лекции. </param>
        /// <exception cref="ArgumentException"> Ошибка в передаваемом имени или дате. </exception>
        public LecturePlan(DateTime date, string name, int idUser, int idLectureStatus)
        {
            if (date < DateTime.Now)
            {
                throw new ArgumentException("Дата и время назначенной лекции не может быть раньше настоящего момента.", nameof(date));
            }
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название лекции не может быть Null или пустым.", nameof(name));
            }

            Date = date;
            Name = name;
            IdUser = idUser;
            IdLectureStatus = idLectureStatus;
        }
    }
}
