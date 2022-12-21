namespace ScopedServiceDemo.Repository
{
    public class SingleRepository : ISingleRepository
    {
        int i=1;
        public int Counter()
        {
            return ++i;
        }
    }
}
