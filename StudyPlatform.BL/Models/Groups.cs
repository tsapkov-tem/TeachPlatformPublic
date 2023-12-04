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
    /// Группа пользователей.
    /// </summary>
    public class Groups
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название группы.
        /// </summary>
        [MaxLength(40)]
        public string Name { get; set; }
        /// <summary>
        /// Ссылки на лекции, которые проводятся в группе
        /// </summary>
        public List<Lecture> Lecture { get; set; } = new();
        /// <summary>
        /// Ссылки на строки в таблицу связей пользователей и групп.
        /// </summary>
        public List<GroupedUsers> GroupedUsers { get; set; } = new();
        /// <summary>
        /// Создать новую группу.
        /// </summary>
        /// <param name="name"> Название группы. </param>
        /// <exception cref="ArgumentException"> Имя группы пустое или Null. </exception>
        public Groups(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название группы не может быть Null или пустым.", nameof(name));
            }
            Name = name;
        } 

    }
}
