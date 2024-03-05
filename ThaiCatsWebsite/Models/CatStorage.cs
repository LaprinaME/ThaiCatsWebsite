using System;

namespace ThaiCatsWebsite.Models
{
    public static class CatStorage
    {
        private static Cat _cat = new Cat();

        public static void SaveCat(string breed, string weight, string color)
        {
            _cat = new Cat()
            {
                Breed = breed,
                Weight = Convert.ToInt32(weight),
                Color = color
            };
        }

        public static Cat GetCat()
        {
            return _cat;
        }
    }
}
