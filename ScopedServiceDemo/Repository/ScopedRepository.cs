namespace ScopedServiceDemo.Repository
{
    public class ScopedRepository: IScopedRepository
    {
        int i = 1;
        public int Counter()
        {
            return ++i;
        }
    }
}
