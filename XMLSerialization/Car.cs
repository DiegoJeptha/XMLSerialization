namespace XMLSerialization
{
    public class Car
    {
        private int m_yearOfMake;
        public int yearOfMake { get; set; }

        public override string ToString() 
        {
            return "Car year: " + m_yearOfMake;
        }
    }
}