using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCore.WebAPI.Model
{
    public class IdentidadeSercreta
    {
        public int Id { get; set; }

        public int NomeReal { get; set; }

        public int HeroiId { get; set; }
        public Heroi Heroi { get; set; }
        public IdentidadeSercreta Identidade { get; set; }
    }
}
