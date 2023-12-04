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
    /// Посещаемость лекций студентами.
    /// </summary>
    public class VisitLecture
    {
        /// <summary>
        /// Айди лекции.
        /// </summary>
        [Required]
        public int IdLecture { get; set; }
        /// <summary>
        /// Ссылка на лекцию.
        /// </summary>
        public Lecture Lecture { get; set; }
        /// <summary>
        /// Айди пользователя.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        /// <summary>
        /// Ссылка на пользователя, посетившего лекцию.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Влитильность присутствия на лекции.
        /// </summary>
        public TimeSpan VisitDuration { get; set; }
        /// <summary>
        /// Время присоединения к лекции.
        /// </summary>
        public DateTime TimeVisit { get; set; }

        /// <summary>
        /// Создать запись посещения.
        /// </summary>
        /// <param name="idLecture"> Айди лекции. </param>
        /// <param name="idUser"> Айди пользователя. </param>
        public VisitLecture(int idLecture, int idUser)
        {
            IdLecture = idLecture;
            IdUser = idUser;
            TimeVisit = DateTime.Now;
        }
    }
}
