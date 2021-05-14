using System;
using System.Collections.Generic;

namespace RepositorioArtigos
{
    class Program
    {
        static void Main(string[] args)
        {
            //--------Artigo 1--------------------------
                //---------Autor 1
            Autor a1 = new Autor();
            a1.Nome = "Alisson";
            a1.Email = "alisson@ba.estudantes.senai.br";
                //---------Autor 2
            Autor a2 = new Autor();
            a2.Nome = "Gisela";
            a2.Email = "gisela@ba.estudantes.senai.br";
                //---------Autor 1
            Autor a3 = new Autor();
            a3.Nome = "Jamile";
            a3.Email =  "jamile@ba.docente.senai.br";
            Artigo art1 = new Artigo();
            art1.Titulo = "Tecnologia e inovação em épocas de pandemia";
            art1.Instituicao = "Senai";
            List<string> palavras = new List<string>();
            palavras.Add("Tecnologia");
            palavras.Add("Inovação");
            palavras.Add("pandemia");
            art1.PalavrasChave = palavras;
            List<Autor> autores = new List<Autor>();
            autores.Add(a1);
            autores.Add(a2);
            art1.Autores = autores;
            //---------------------------Artigo 2 ---------------
            Artigo art2 = new Artigo();
            art2.Titulo = "Educação Remota: Uma alternativa em meio a pandemia";
            art2.Instituicao = "Senai";
            List<string> palavras2 = new List<string>();
            palavras2.Add("Pedagogia");
            palavras2.Add("pandemia");
            art2.PalavrasChave = palavras2;
            List<Autor> autores1 = new List<Autor>();
            autores1.Add(a3);
            art2.Autores = autores1;
            //--------------------------Repositório --------------------------
            Repositorio repo1 = new Repositorio();
            List<Artigo> artigos = new List<Artigo>();
            artigos.Add(art1);
            artigos.Add(art2);
            repo1.Artigos = artigos;
            /////////////////////////////////////////////////////////////////
            Console.WriteLine("Informe a palavra chave a ser buscada: ");
            string palavraChave = Console.ReadLine();
            List<Artigo> artigosBuscados = repo1.ArtigosPorPalavraChave(palavraChave);
            if(artigosBuscados !=  null){
                foreach (Artigo a in artigosBuscados){
                    Console.WriteLine("Titulo: "+a.Titulo);
                    Console.WriteLine("Autores: ");
                    foreach(Autor autor1 in a.Autores){
                        Console.WriteLine(autor1.Nome);
                    }
                }
            }


           


        }
    }
}
