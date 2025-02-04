namespace DIServicesLifetime.Services
{
    public class ScoppedGuideService : IScoppedGuideService
    {

        private readonly Guid Id;
        public ScoppedGuideService()
        {
            Id = Guid.NewGuid();
        }
        public string getGuide()
        {
            return Id.ToString();
        }
    }
}
