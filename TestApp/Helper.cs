using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace TestApp
{
    /// <summary>
    /// Содержит вспомогательные методы.
    /// </summary>
    public static class Helper
    {
        /// <summary>
        /// Очищает базу и добавляет начальный набор тестовых данных.
        /// </summary>
        public static void AddTestData(StorageContext db)
        {
            db.OuterwearStorage.RemoveRange(db.OuterwearStorage.ToList());
            db.FootwearStorage.RemoveRange(db.FootwearStorage.ToList());
            db.WorkClothes.RemoveRange(db.WorkClothes.ToList());
            db.ClothesSubtypes.RemoveRange(db.ClothesSubtypes.ToList());
            db.ClothesTypes.RemoveRange(db.ClothesTypes.ToList());
            db.Units.RemoveRange(db.Units.ToList());

            Unit unit1 = new Unit { UnitName = "штука" };
            Unit unit2 = new Unit { UnitName = "пара" };

            db.Units.Add(unit1);
            db.Units.Add(unit2);

            ClothesType cType1 = new ClothesType { TypeName = "верхняя одежда" };
            ClothesType cType2 = new ClothesType { TypeName = "обувь" };

            db.ClothesTypes.Add(cType1);
            db.ClothesTypes.Add(cType2);

            ClothesSubtype cSubtype1 = new ClothesSubtype { SubtypeName = "куртка", ClothesType = cType1, Unit = unit1 };
            ClothesSubtype cSubtype2 = new ClothesSubtype { SubtypeName = "жилет", ClothesType = cType1, Unit = unit1 };
            ClothesSubtype cSubtype3 = new ClothesSubtype { SubtypeName = "ботинки", ClothesType = cType2, Unit = unit2 };

            db.ClothesSubtypes.Add(cSubtype1);
            db.ClothesSubtypes.Add(cSubtype2);
            db.ClothesSubtypes.Add(cSubtype3);

            WorkClothes wClothes1 = new WorkClothes { Description = "утепленная", ClothesSubtype = cSubtype1 };
            WorkClothes wClothes2 = new WorkClothes { Description = "для руководителя", ClothesSubtype = cSubtype1 };
            WorkClothes wClothes3 = new WorkClothes { Description = "кирзовые", ClothesSubtype = cSubtype3 };
            WorkClothes wClothes4 = new WorkClothes { Description = "мужские утепленные", ClothesSubtype = cSubtype3 };
            WorkClothes wClothes5 = new WorkClothes { Description = "защитный", ClothesSubtype = cSubtype2 };

            db.WorkClothes.Add(wClothes1);
            db.WorkClothes.Add(wClothes2);
            db.WorkClothes.Add(wClothes3);
            db.WorkClothes.Add(wClothes4);
            db.WorkClothes.Add(wClothes5);

            Outerwear outerwear1 = new Outerwear { Size = 40, Height = 160, Quantity = 5, WorkClothes = wClothes1 };
            Outerwear outerwear2 = new Outerwear { Size = 60, Height = 180, Quantity = 3, WorkClothes = wClothes1 };
            Outerwear outerwear3 = new Outerwear { Size = 50, Height = 150, Quantity = 1, WorkClothes = wClothes2 };
            Outerwear outerwear4 = new Outerwear { Size = 60, Height = 185, Quantity = 10, WorkClothes = wClothes5 };

            db.OuterwearStorage.Add(outerwear1);
            db.OuterwearStorage.Add(outerwear2);
            db.OuterwearStorage.Add(outerwear3);
            db.OuterwearStorage.Add(outerwear4);

            Footwear footwear1 = new Footwear { Size = 41, Quantity = 3, WorkClothes = wClothes3 };
            Footwear footwear2 = new Footwear { Size = 45, Quantity = 7, WorkClothes = wClothes3 };
            Footwear footwear3 = new Footwear { Size = 43, Quantity = 9, WorkClothes = wClothes4 };

            db.FootwearStorage.Add(footwear1);
            db.FootwearStorage.Add(footwear2);
            db.FootwearStorage.Add(footwear3);

            db.SaveChanges();
        }
    }
}
