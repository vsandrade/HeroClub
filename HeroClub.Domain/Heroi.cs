using System;
using System.Collections.Generic;

namespace HeroClub.Domain
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }        
        public string Sexo { get; set; }
        public string Foto { get; set; }
        public float? Peso { get; set; }
        public float? Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataObto { get; set; }
        public string Poderes { get; set; }
        public List<Foto> Fotos { get; set; }
        public List<Citacao> Citacoes { get; set; }
        public List<EquipeHeroi> EquipeHerois { get; set; }
        public List<EquipeHeroiBatalha> EquipeHeroiBatalhas { get; set; }
        public User User { get; set; }
    }
}