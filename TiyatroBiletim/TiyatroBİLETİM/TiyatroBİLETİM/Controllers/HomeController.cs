using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TiyatroBİLETİM.Enity;
using TiyatroBİLETİM.Models;

namespace TiyatroBİLETİM.Controllers
{
    public class HomeController : Controller
    {
        DataContext _context = new DataContext();
        // GET: Home
        public ActionResult Index()
        {
            var oyunlar = _context.Oyunlars
             .Where(i => i.IsHome && i.Yer).Select(i => new Model()
             {
                 Id= i.Id,
                 Name= i.Name,
                 Description= i.Description.Length>50?i.Description.Substring(0,47)+"...":i.Description,
                 Price= i.Price,
                 Image= i.Image,
                 KategorıId=i.KategorıId
             }).ToList();
            return View(oyunlar);
        }
        public ActionResult Oyunlar(int? id)
        {

            var oyunlar = _context.Oyunlars
             .Where(i =>i.Yer).Select(i => new Model()
             {
                 Id = i.Id,
                 Name = i.Name,
                 Description = i.Description.Length > 50 ? i.Description.Substring(0, 47) + "..." : i.Description,
                 Price = i.Price,
                 Image = i.Image,
                 KategorıId = i.KategorıId
             }).AsQueryable();
            if (id != null)
            {
               oyunlar=oyunlar.Where(i => i.KategorıId == id);
            }
            return View(oyunlar.ToList());

        }

        public PartialViewResult GetKategois()
        {
            return PartialView(_context.Kategoris.ToList());
        }
        public ActionResult FilmDetayları(int id)
        {
            return View(_context.Oyunlars.Where(i => i.Id == id).FirstOrDefault()); 
        }

        public ActionResult BiletFiyatlari()
        {
            return View();
        }
        public ActionResult Hakkimizda()
        {
            return View();
        }
        

    }
}