using System.Linq;
using Microsoft.AspNet.Mvc;

namespace BDPZespolowy.Controllers
{
    public class KlientStrController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}