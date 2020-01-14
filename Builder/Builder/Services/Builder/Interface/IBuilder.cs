using Builder.Services.Interfaces;

namespace Builder.Services.Builder.Interface
{
    public interface IBuilder
    {
        void Reset();
        void SetSeats(int _nNumber);
        void SetEngine(IEngine _engine);
        void SetTripComputer();
        void SetGPS();
    }
}
