using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace TestApp
{
    /// <summary>
    /// Единица верхней одежды, которая хранится на складе.
    /// </summary>
    [Table("OuterwearStorage")]
    public class Outerwear
    {
        public int Id { get; set; }

        /// <summary>
        /// Размер.
        /// </summary>
        [DisplayName("Размер")]
        public int Size { get; set; }
        /// <summary>
        /// Рост.
        /// </summary>
        [DisplayName("Рост")]
        public int Height { get; set; }
        /// <summary>
        /// Количество.
        /// </summary>
        [DisplayName("Количество")]
        public int Quantity { get; set; }

        public int WorkClothesId { get; set; }
        public WorkClothes WorkClothes { get; set; }
    }
}
