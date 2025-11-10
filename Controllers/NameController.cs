using Microsoft.AspNetCore.Mvc;

namespace VersionControl.Controllers;

public class NameController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return new JsonResult(new { name = "Corey DeRossett" });
    }
}
