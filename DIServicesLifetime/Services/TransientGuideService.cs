namespace DIServicesLifetime.Services
{
    public class TransientGuideService : ITransientGuideService
    {

        private readonly Guid Id;
        public TransientGuideService()
        {
            Id =Guid.NewGuid();
        }
        public string getGuide()
        {
            return Id.ToString();
        }
    }
}
