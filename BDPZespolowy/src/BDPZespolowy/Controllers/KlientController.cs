using System.Linq;
using Microsoft.AspNet.Mvc;

namespace BDPZespolowy.Controllers
{
    public class KlientController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}