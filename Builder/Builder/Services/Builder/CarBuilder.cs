using Builder.Services.Builder.Interface;
using Builder.Services.Interfaces;

namespace Builder.Services.Builder
{
    public class CarBuilder : IBuilder
    {
        private Car Vehiculo = new Car();

        public CarBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.Vehiculo = new Car();
        }

        public void SetEngine(IEngine _engine)
        {
            this.Vehiculo.Add(_engine.GetEngine());
        }

        public void SetGPS()
        {
            this.Vehiculo.Add("GPS a Carro");
        }

        public void SetSeats(int _nNumber)
        {
            this.Vehiculo.Add(string.Format("{0} Asientos al Carro",_nNumber));
        }

        public void SetTripComputer()
        {
            this.Vehiculo.Add("Computadora de Viaje Carro");
        }

        public Car GetResult()
        {
            Car result = this.Vehiculo;

            this.Reset();

            return result;
        }
    }
}
