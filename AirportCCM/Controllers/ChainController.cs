using AirportCCM.Services.ChainOfResponsibility;
using Microsoft.AspNetCore.Mvc;

namespace AirportCCM.Controllers
{
    public class ChainController : Controller
    {
        public IActionResult Test()
        {
            var ground = new GroundStaffHandler();
            var supervisor = new SupervisorHandler();
            var manager = new ManagerHandler();

            // Cadena configurada
            ground.SetNext(supervisor).SetNext(manager);

            // Pruebas
            ground.Handle("problema con equipaje perdido");
            ground.Handle("necesito autorización especial para vuelo");
            ground.Handle("solicitud VIP para sala ejecutiva");

            return Content("Chain of Responsibility completado. Revisa la consola.");
        }
    }
}
