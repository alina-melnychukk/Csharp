namespace exam
{
    class Cars
    {
        public enum Colors { Null, Red, Black, White, Green };

        public string Model
        {
            private set; get;
        }

        public int Price
        {
            private set; get;
        }

        public int Year
        {
            private set; get;
        }

        public Colors Color
        {
            private set; get;
        }

        public Cars(string model, int price, int year, Colors color)
        {
            Model = model;
            Price = price;
            Year = year;
            Color = color;
        }
    }
}