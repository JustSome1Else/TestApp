using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace TestApp
{
    /// <summary>
    /// Контекст данных.
    /// </summary>
    public class StorageContext : DbContext
    {
        public StorageContext() { }

        public DbSet<Outerwear> OuterwearStorage { get; set; }
        public DbSet<Footwear> FootwearStorage { get; set; }
        public DbSet<Unit> Units { get; set; }
        public DbSet<ClothesType> ClothesTypes { get; set; }
        public DbSet<ClothesSubtype> ClothesSubtypes { get; set; }
        public DbSet<WorkClothes> WorkClothes { get; set; }
    }
}
