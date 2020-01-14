using Builder.Services;
using Builder.Services.Builder;
using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code creates a builder object, passes it to the
            // director and then initiates the construction process. The end
            // result is retrieved from the builder object.
            var director = new Director();
            var carBuilder = new CarBuilder();
            var sportEngine = new SportEngine();
            var workEngine = new WorkEngine();
            director.Builder = carBuilder;
            director.Engine = workEngine;

            Console.WriteLine("Crear el carro:");
            director.CrearCarro();
            Console.WriteLine(carBuilder.GetResult().ListParts());


            var manualBuilder = new ManualBuilder();
            director.Builder = manualBuilder;
            director.Engine = sportEngine;

            Console.WriteLine("Crear el manual:");
            director.CrearManual();
            Console.WriteLine(manualBuilder.GetResult().ListParts());

            Console.ReadKey();
        }
    }
}
