using Microsoft.AspNetCore.Mvc;
using Odev40.Data;

namespace Odev40.Controllers
{
    public class OyunController : Controller
    {
        private readonly ILogger<OyunController> _logger;

        private readonly UygulamaDbContext _db;

        public OyunController(ILogger<OyunController> logger, UygulamaDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public IActionResult Listele()
        {
            return View(_db.Oyunlar.ToList());
        }

        public IActionResult Ekle()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Ekle(Oyun oyun)
        {
            if (ModelState.IsValid)
            {
                //metottaki ürün parametresi post edilince formdan dolu gelecek. dolayisi ile bize de db'ye eklemek kalacak.
                _db.Oyunlar.Add(oyun);
                _db.SaveChanges();
                return RedirectToAction("Listele"); // bittikten sonra tüm ürünlerin oldugu yere gitmek istiyorum.Yani "Listele" action'ina
            }
            return View(oyun);
        }

        public IActionResult Guncelle(int id) 
        {
            Oyun oyun = _db.Oyunlar.FirstOrDefault(o => o.Id == id);
            return View(oyun);
        }

        [HttpPost]
        public IActionResult Guncelle(Oyun oyun)
        {
            _db.Oyunlar.Update(oyun);
            _db.SaveChanges();
            return RedirectToAction("Listele");
        }

        public IActionResult Sil(int id) 
        {
            Oyun oyun = _db.Oyunlar.FirstOrDefault(o => o.Id == id);
            return View(oyun);
        }

        [HttpPost]
        public IActionResult Sil(Oyun oyun)
        {
            _db.Oyunlar.Remove(oyun);
            _db.SaveChanges();
            return RedirectToAction("Listele");
        }


    }
}
