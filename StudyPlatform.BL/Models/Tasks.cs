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
    /// Задание, задаваемое студентам.
    /// </summary>
    public class Tasks 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название задания.
        /// </summary>
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
        /// <summary>
        /// Описание задания.
        /// </summary>
        [MaxLength(1000)]
        public string Description { get; set; } = "";
        /// <summary>
        /// Айди группы, для которого задано задание.
        /// </summary>
        [Required]
        public int IdGroup { get; set; }
        /// <summary>
        /// Ссыка на группу в которой задано задание.
        /// </summary>
        public Groups Group { get; set; }
        /// <summary>
        /// Ссылка на файлы приложенные в задание.
        /// </summary>
        public IList<Files> Files { get; set; }
        /// <summary>
        /// Дата назначения задания.
        /// </summary>
        [Required]
        public DateTime DateStart { get; set; }
        /// <summary>
        /// Дата окончания задания.
        /// </summary>
        [Required]
        public DateTime DateEnd { get; set; }
        /// <summary>
        /// Возможность сдачи после окончания срока задания.
        /// </summary>
        [Required]
        public bool CanBeLate { get; set; }
        /// <summary>
        /// Айди пользователя, задавшего задание.
        /// </summary>
        [Required]
        public int IdTeacher { get; set; }
        /// <summary>
        /// Ссылка на пользователя задавшего задание.
        /// </summary>
        public User Teacher { get; set; }

        /// <summary>
        /// Создать новое задание для студентов.
        /// </summary>
        /// <param name="name"> Название задания. </param>
        /// <param name="idGroup"></param>
        /// <param name="dateEnd"></param>
        /// <param name="canBeLate"></param>
        /// <param name="idTeacher"></param>
        /// <exception cref="ArgumentException"></exception>
        public Tasks(string name, int idGroup, DateTime dateEnd, bool canBeLate, int idTeacher)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название задания не может быть пустым или Null.", nameof(name));
            }

            Name = name;
            IdGroup = idGroup;
            DateStart = DateTime.Now;
            DateEnd = dateEnd;
            CanBeLate = canBeLate;
            IdTeacher = idTeacher;
        }
    }
}
