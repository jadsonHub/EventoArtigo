using System.Collections.Generic;

namespace RepositorioArtigos
{
    public class Artigo
    {
        public string Titulo { get; set; }
        public string Instituicao { get; set; }
        public List<string> PalavrasChave { get; set; }
        public ICollection<Autor> Autores { get; set; }

        
    }
}