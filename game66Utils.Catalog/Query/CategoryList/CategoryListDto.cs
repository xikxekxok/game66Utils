using System;

namespace game66Utils.Catalog.Query.CategoryList
{
    public class CategoryListDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int ProductCount { get; set; }

        public override string ToString()
        {
            return $"{Name} (Количество продуктов: {ProductCount})";
        }
    }
}
