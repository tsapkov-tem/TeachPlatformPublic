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
    /// Групповой чат.
    /// </summary>
    public class GroupChat
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Имя группового чата.
        /// </summary>
        [MaxLength(40)]
        public string Name { get; set; }
        /// <summary>
        /// Айди группа, в которой создан чат.
        /// </summary>
        [Required]
        public int IdGroup { get; set; }


        /// <summary>
        /// Создать групповой чат.
        /// </summary>
        /// <param name="name"> Имя группового чата </param>
        /// <param name="idGroup"> Айди группы, в которой создан чат</param>
        /// <exception cref="ArgumentException">Имя группового чата Null или пустое. </exception>
        public GroupChat(string name, int idGroup)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя группового чата не может быть Null или пустым.", nameof(name));
            }
            Name = name;
            IdGroup = idGroup;
        }
    }
}
