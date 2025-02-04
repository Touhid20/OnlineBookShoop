namespace DIServicesLifetime.Services
{
    public class SingletonGuidService : ISingletoGuidService
    {
        private readonly Guid Id;
        public SingletonGuidService()
        {
            Id = Guid.NewGuid();
        }
        public string getGuide()
        {
            return Id.ToString();
        }
    }
}
