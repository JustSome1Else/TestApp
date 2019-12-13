namespace TestApp
{
    /// <summary>
    /// Спецодежда.
    /// </summary>
    public class WorkClothes
    {
        public int Id { get; set; }

        /// <summary>
        /// Описание.
        /// </summary>
        public string Description { get; set; }

        public int ClothesSubtypeId { get; set; }
        public ClothesSubtype ClothesSubtype { get; set; }
    }
}
