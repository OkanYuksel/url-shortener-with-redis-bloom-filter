using Microsoft.AspNetCore.Mvc;

namespace url_shortener_with_redis_bloom_filter.Controllers;

public class UrlController : Controller
{
    // GET
    public IActionResult Index()
    {
        return View();
    }
}