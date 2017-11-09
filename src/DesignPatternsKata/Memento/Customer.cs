namespace DesignPatternsKata.Memento
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        internal Customer Clone()
        {
            return (Customer)this.MemberwiseClone();
        }
    }
}