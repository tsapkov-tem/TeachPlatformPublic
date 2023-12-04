
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
    /// Роль пользователя.
    /// </summary>
    public class Role 
    {
        [Key]
        public int Id { get; set; }
        /// <summary>
        /// Название роли.
        /// </summary>
        [Required]
        public string Name { get; set; }
        
        /// <summary>
        /// Создать новую роль пользователя.
        /// </summary>
        /// <param name="name"> Название роли. </param>
        /// <exception cref="ArgumentException">Название роли Null или пустое.</exception>
        public Role(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Название роли не может быть Null или пустым.", nameof(name));
            }

            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
