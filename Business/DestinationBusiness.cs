namespace Business
{
    using Data.Model;
    using Data;
    public class DestinationBusiness
    {
        private DestinationContext destinationContext;
        public List<Destination> GetAll()
        {
            using (destinationContext = new DestinationContext())
            {
                return destinationContext.Destinations.ToList();
            }
        }
        public void Add(Destination product)
        {
            using (destinationContext = new DestinationContext())
            {
                destinationContext.Destinations.Add(product);
                destinationContext.SaveChanges();

            }
        }
        public Destination Get(int id)
        {
            using (destinationContext = new DestinationContext())
            {
                return destinationContext.Destinations.Find(id);

            }
        }
        public void Update(Destination destination)
        {
            using (destinationContext = new DestinationContext())
            {

                var item = destinationContext.Destinations.Find(destination.Id);
                if (item != null)
                {
                    destinationContext.Entry(item).CurrentValues.SetValues(destination);
                    destinationContext.SaveChanges();
                }

            }
        }
        public void Delete(int id)
        {
            using (destinationContext = new DestinationContext())
            {
                var product = destinationContext.Destinations.Find(id);
                if (product != null)
                {
                    destinationContext.Destinations.Remove(product);
                    destinationContext.SaveChanges();
                }
            }
        }
    }
}