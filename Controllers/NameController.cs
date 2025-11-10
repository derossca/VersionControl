using Microsoft.AspNetCore.Mvc;

namespace VersionControl.Controllers;
[Route("Name")]
public class NameController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return new JsonResult(new { name = "Corey DeRossett" });
    }
}
