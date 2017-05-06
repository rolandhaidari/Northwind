namespace NorthwindWPF
{
   public class Categorysales
    {
        public string Categoryname { set; get; }
        public double Categorysum { set; get; }
        public Categorysales(string name, double sum)
        {
            Categoryname = name;
            Categorysum = sum;
        }
        public Categorysales()
        {
            Categoryname = "default";
            Categorysum = 0;
        }
    }
}