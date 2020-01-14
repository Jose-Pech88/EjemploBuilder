using Builder.Services.Builder.Interface;
using Builder.Services.Interfaces;

namespace Builder.Services.Builder
{
    public class ManualBuilder : IBuilder
    {
        private Manual Instruccion = new Manual();

        public ManualBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.Instruccion = new Manual();
        }

        public void SetEngine(IEngine _engine)
        {
            this.Instruccion.Add(_engine.GetEngine());
        }

        public void SetGPS()
        {
            this.Instruccion.Add("GPS a Carro");
        }

        public void SetSeats(int _nNumber)
        {
            this.Instruccion.Add(string.Format("{0} Asientos al Carro", _nNumber));
        }

        public void SetTripComputer()
        {
            this.Instruccion.Add("Computadora de Viaje Carro");
        }

        public Manual GetResult()
        {
            Manual result = this.Instruccion;

            this.Reset();

            return result;
        }
    }
}
