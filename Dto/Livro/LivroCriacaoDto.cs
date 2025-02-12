using WebApiTeste.Models;
using WebApiTeste.Vinculo;

namespace WebApiTeste.Dto.Livro
{
    public class LivroCriacaoDto
    {
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
