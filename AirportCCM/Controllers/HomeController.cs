using AirportCCM.Models;
using AirportCCM.Services;
using AirportCCM.Services.Commands;
using AirportCCM.Services.Decorator;
using AirportCCM.Services.Mediator;
using AirportCCM.Services.States;
using AirportCCM.Services.Strategies;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace AirportCCM.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Test()
        {
            var vuelo = FlightFactory.CreateFlight("emergencia");
            vuelo.FlightCode = "MX123";
            vuelo.LandingStrategy = new EmergencyLanding();
            vuelo.Land();

            return Content("Prueba completada. Revisa la consola.");
        }

        public IActionResult AlertaEmergencia()
        {
            ViewBag.Mensaje = "ATENCIÓN: Aterrizaje de emergencia para vuelo MX123";
            return View();
        }

        public IActionResult ControlTorre()
        {
            var mediator = new AirportMediator();
            var pista = new Runway("A1");

            // Simula clima y operaciones
            mediator.ChangeWeather("Tormenta eléctrica");
            string msg1 = mediator.AssignRunway(pista, "usar");
            string msg2 = mediator.AssignRunway(pista, "mantenimiento");

            return Content($"{msg1}\n{msg2}");
        }

        public IActionResult SimularVuelo()
        {
            var tower = new ControlTower();

            var vuelo = FlightFactory.CreateFlight("emergencia");
            vuelo.FlightCode = "MX123";
            tower.RegisterFlight(vuelo);

            vuelo.Proceed(); // Scheduled -> InFlight
            vuelo.Proceed(); // InFlight -> Landing
            vuelo.Proceed(); // Landing -> Finished

            return Content("Simulación completada. Revisa la consola.");
        }

        public IActionResult ObserverTest()
        {
            var tower = new ControlTower();
            var flight = new Flight { FlightCode = "MX123" };

            // La torre se suscribe al vuelo
            flight.Attach(tower);

            // El vuelo cambia de estado varias veces
            flight.ChangeState(new ScheduledState());
            flight.ChangeState(new InFlightState());
            flight.ChangeState(new LandingState());
            flight.ChangeState(new FinishedState());

            return Content("Observer Test completado. Revisa la consola.");
        }

        public IActionResult CommandTest()
        {
            var tower = new ControlTower();
            var flight = FlightFactory.CreateFlight("comercial");
            flight.FlightCode = "AM202";

            tower.RegisterFlight(flight);
            flight.Attach(tower);

            var invoker = new CommandInvoker();

            invoker.AddCommand(new SendAlertCommand("Cambio de clima intenso"));
            invoker.AddCommand(new AuthorizeTakeOffCommand(flight));
            invoker.AddCommand(new SendAlertCommand("Pista despejada"));

            invoker.ExecuteAll();

            return Content("Command Test completado. Revisa la consola.");
        }

        public IActionResult DecoratorTest()
        {
            var flight = FlightFactory.CreateFlight("comercial");
            flight.FlightCode = "AM303";

            // Aplicamos varios decoradores dinámicamente
            IFlightProcess decorated = new VipFlightDecorator(flight);
            decorated = new HazardousCargoDecorator(decorated);

            decorated.Process();

            return Content("Decorator Test completado. Revisa la consola.");
        }
    }
}
