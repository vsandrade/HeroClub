using System;
using System.Collections.Generic;

namespace HeroClub.WebAPI.Dtos
{
    public class HeroiDto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NomeReal { get; set; }
        public string Sexo { get; set; }
        public string Foto { get; set; }
        public float? Peso { get; set; }
        public float? Altura { get; set; }
        public DateTime DataNascimento { get; set; }
        public DateTime? DataObto { get; set; }
        public string Poderes { get; set; }
        public List<FotoDto> Fotos { get; set; }
        public List<CitacaoDto> Citacoes { get; set; }
        public List<EquipeHeroiDto> EquipeHerois { get; set; }
        public List<EquipeHeroiBatalhaDto> EquipeHeroiBatalhas { get; set; }
    }
}