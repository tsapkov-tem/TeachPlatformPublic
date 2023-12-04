using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudyPlatform.BL.Models
{
    /// <summary>
    /// Учебная лекция.
    /// </summary>
    public class Lecture 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Айди группы, в которой проводится лекция.
        /// </summary>
        [Required]
        public int IdGroup { get; set; }
        /// <summary>
        /// Ссылка на группу, в которой проводится лекция.
        /// </summary>
        public Group Group { get; set; }
        /// <summary>
        /// Дата начала лекции.
        /// </summary>
        [Required]
        public DateTime DateStart { get; set; }
        /// <summary>
        /// Дата окончания лекции.
        /// </summary>
        [Required]
        public DateTime DateEnd { get; set; }
        /// <summary>
        /// Айди пользователя, который начал лекцию, и управлял ею.
        /// </summary>
        [Required]
        public int IdTeacher { get; set; }
        /// <summary>
        /// Длительность лекции.
        /// </summary>
        public TimeSpan Duration => DateStart - DateEnd;
        /// <summary>
        /// Создать новую лекцию.
        /// </summary>
        /// <param name="idGroup"> Айди группы, в которой проводится лекция. </param>
        /// <param name="idTeacher"> Длительность лекции. </param>
        public Lecture(int idGroup, int idTeacher)
        {
            // TODO:
            IdGroup = idGroup;
            DateStart = DateTime.Now;
            IdTeacher = idTeacher;
        }
    }
}
