using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TiyatroBİLETİM.Enity
{
    public class Kategori
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public List<Oyunlarim> Oyunlars { get; set; }
    }
}