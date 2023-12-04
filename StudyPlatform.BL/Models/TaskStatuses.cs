
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPlatform.BL.Models
{
    /// <summary>
    /// Статус домашней работы.
    /// </summary>
    public class TaskStatuses 
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Название статуса.
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// Создать новый статус для задания.
        /// </summary>
        /// <param name="name"> Название статуса. </param>
        /// <exception cref="ArgumentException"> Название статуса пустое или Null. </exception>
        public TaskStatuses(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название статуса не может быть Null или пустое.");
            }
            Name = name;
        }
    }
}
