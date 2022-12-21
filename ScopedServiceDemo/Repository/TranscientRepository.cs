namespace ScopedServiceDemo.Repository
{
    public class TranscientRepository: ITranscientRepository
    {
        int i = 1;
        public int Counter()
        {
            return ++i;
        }
    }
}
