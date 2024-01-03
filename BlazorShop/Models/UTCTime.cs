
namespace BlazorShop.Models
{
    public class UTCTime : ITime
    {
        public DateTime GetTime()
        {
            return DateTime.UtcNow;
        }
    }
}
