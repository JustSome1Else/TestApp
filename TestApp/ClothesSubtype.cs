using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp
{
    /// <summary>
    /// Подтип одежды.
    /// </summary>
    public class ClothesSubtype
    {
        public int Id { get; set; }
        /// <summary>
        /// Название подтипа одежды.
        /// </summary>
        public string SubtypeName { get; set; }

        public int ClothesTypeId { get; set; }
        public ClothesType ClothesType { get; set; }
        public int UnitId { get; set; }
        public Unit Unit { get; set; }
    }
}
