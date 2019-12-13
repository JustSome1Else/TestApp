using System.ComponentModel.DataAnnotations.Schema;

namespace TestApp
{
    /// <summary>
    /// Единица обуви, которая хранится на складе.
    /// </summary>
    [Table("FootwearStorage")]
    public class Footwear
    {
        public int Id { get; set; }

        /// <summary>
        /// Размер.
        /// </summary>
        public int Size { get; set; }
        /// <summary>
        /// Количество.
        /// </summary>
        public int Quantity { get; set; }

        public int WorkClothesId { get; set; }
        public WorkClothes WorkClothes { get; set; }
    }
}
