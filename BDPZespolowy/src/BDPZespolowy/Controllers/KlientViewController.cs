using System.Linq;
using Microsoft.AspNet.Mvc;

namespace BDPZespolowy.Controllers
{
    public class KlientViewController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}