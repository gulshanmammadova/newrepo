using CarModelMarka.DataAccesLayer;
using CarModelMarka.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
namespace CarModelMarka.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            List<Model> models = await _context.Models.Include(x => x.Cars).Include(x => x.Marka).ToListAsync();
            return View(models);
        }
    }
}
