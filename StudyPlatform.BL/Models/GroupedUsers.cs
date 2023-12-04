using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudyPlatform.BL.Models
{
    /// <summary>
    /// Таблица связи пользователей и групп, в которые они включены.
    /// </summary>
    public class GroupedUsers
    {
        /// <summary>
        /// Айди пользователей.
        /// </summary>
        [Required]
        public int IdUser { get; set; }
        /// <summary>
        /// Ссылка на пользователя в группе.
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Айди группы.
        /// </summary>
        [Required]
        public int IdGroup { get; set; }
        /// <summary>
        /// Ссылка на группу, в которой находится пользователь.
        /// </summary>
        public Group Group { get; set; }

        /// <summary>
        /// Айди роли пользователя в этой группе.
        /// </summary>
        [Required]
        public int IdRole { get; set; }
        /// <summary>
        /// Ссылка на роль пользователя в этой группе.
        /// </summary>
        public Role Role { get; set; }

        /// <summary>
        /// Пригласить пользователя в группу.
        /// </summary>
        /// <param name="idUser"> Айди пользователя. </param>
        /// <param name="idGroup"> Айди группы. </param>
        /// <param name="roleName"> Имя роли, которую получает пользователь. </param>
        public GroupedUsers(int idUser, int idGroup, int idRole)
        {
            IdRole = idRole;
            IdUser = idUser;
            IdGroup = idGroup;
        }
    }
}
