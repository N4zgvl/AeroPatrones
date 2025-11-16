using AirportCCM.Services.TemplateMethod;
using Microsoft.AspNetCore.Mvc;

namespace AirportCCM.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Test()
        {
            var commercial = new CommercialLanding();
            var military = new MilitaryLanding();
            var privateJet = new PrivateLanding();

            commercial.ExecuteLanding("Vuelo AM300");
            military.ExecuteLanding("Vuelo MXF22");
            privateJet.ExecuteLanding("Vuelo PRIV-77");

            return Content("Template Method completado. Revisa la consola.");
        }
    }
}
