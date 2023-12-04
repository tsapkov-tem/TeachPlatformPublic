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
    /// Домашняя работа.
    /// </summary>
    public class Homework
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Айди студента, сдавшего работу.
        /// </summary>
        [Required]
        public int IdStudent { get; set; }
        /// <summary>
        /// Ссылка на пользователя, сдавшего работу.
        /// </summary>
        public User Student { get; set; }
        /// <summary>
        /// Айди преподавателя, оценившего работу.
        /// </summary>
        public int? IdTeacher { get; set; }
        /// <summary>
        /// Айди задания, по которому сдается работа. 
        /// </summary>
        [Required]
        public int IdTask { get; set; }
        /// <summary>
        /// Ссылка на задание.
        /// </summary>
        public Task Task { get; set; }
        /// <summary>
        /// Ссылка на файлы приложенные в домашнюю работу.
        /// </summary>
        public IList<Files> Files { get; set; }
        /// <summary>
        /// Дата сдачи работы.
        /// </summary>
        [Required]
        public DateTime DateDelivery { get; set; }
        /// <summary>
        /// Айди на статус задания.
        /// </summary>
        [Required]
        public int IdStatus { get; set; }
        /// <summary>
        /// Ссылка на статус задания.
        /// </summary>
        public TaskStatuses Status { get; set; }

        /// <summary>
        /// Создать домашнюю работу при первой сдаче задания.
        /// </summary>
        /// <param name="idStudent"> Айди студента, сдавшего работу. </param>
        /// <param name="idTask"> Айди задания, по которому сдается работа. </param>
        /// <param name="idStatus"> Айди статуса домашней работы. </param>
        public Homework(int idStudent, int idTask, int idStatus)
        {
            IdStudent = idStudent;
            IdTask = idTask;
            DateDelivery = DateTime.Now;
            IdStatus = idStatus;
        }
    }
}
