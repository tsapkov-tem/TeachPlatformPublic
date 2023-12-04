
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyPlatform.BL.Models
{
    public class Files 
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        /// <summary>
        /// Название файла.
        /// </summary>
        [Required]
        [MaxLength(100)]
        public string Name { get; set; }
        /// <summary>
        /// Данные файла.
        /// </summary>
        [Required]
        public byte[] FileData { get; set; }
        /// <summary>
        /// Создать новый файл.
        /// </summary>
        /// <param name="name"> Название файлов. </param>
        /// <param name="fileData"> Данные файла. </param>
        public Files(string name, byte[] fileData)
        {
            // TODO:
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException("Имя файла не может быть Null или пустым.", nameof(name));
            }
            Name = name;
            FileData = fileData;
        }
    }
}
