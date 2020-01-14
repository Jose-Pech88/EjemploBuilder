using Builder.Services.Builder.Interface;
using Builder.Services.Interfaces;

namespace Builder.Services
{
    public class Director
    {
        private IBuilder _builder;
        private IEngine _engine;

        public IBuilder Builder
        {
            set { _builder = value; }
        }

        public IEngine Engine
        {
            set { _engine = value; }
        }

        // The Director can construct several product variations using the same
        // building steps.
        public void CrearCarro()
        {
            this._builder.Reset();
            this._builder.SetEngine(_engine);
            this._builder.SetGPS();
            this._builder.SetSeats(2);
            this._builder.SetTripComputer();
            
        }

        public void CrearManual()
        {
            this._builder.Reset();
            this._builder.SetEngine(_engine);
            this._builder.SetGPS();            
            this._builder.SetTripComputer();
        }
    }
}
