using System.Collections;
using System.Collections.Generic;

namespace RepositorioArtigos
{
    public class Repositorio
    {
        public ICollection<Artigo> Artigos { get; set; }

        public List<Artigo> ArtigosPorPalavraChave(string PalavrasChave){
            List<Artigo> artigosComPalavraChave = new List<Artigo>();
            foreach(var artigo in Artigos){
                if(artigo.PalavrasChave.Exists(a => a == PalavrasChave)){
                    artigosComPalavraChave.Add(artigo);
                }
            }
            return artigosComPalavraChave;
        }
    }
}