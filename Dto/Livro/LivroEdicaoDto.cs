using WebApiTeste.Models;
using WebApiTeste.Vinculo;

namespace WebApiTeste.Dto.Livro
{
    public class LivroEdicaoDto
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public AutorVinculoDto Autor { get; set; }
    }
}
