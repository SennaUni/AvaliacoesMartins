using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Trabalho_Programação__Colections___Orientação_de_Objetos_.Entity;
using Newtonsoft.Json;

namespace Trabalho_Programação__Colections___Orientação_de_Objetos_.Communs
{
    class File
    {
        static public void DocumentoListaProdutosJSON(String localJson, List<Produto> listaProdutos)
        {
            StreamWriter file = new StreamWriter(localJson);
            listaProdutos.ForEach(produto =>
            {
                string produtoJson = JsonConvert.SerializeObject(produto);
                file.WriteLine(produtoJson.ToString());
            });
            file.Close();
        }

        static public List<Produto> LerDocumentoProdutosJson(String local)
        {
            StreamReader file = new StreamReader(local);
            string line;
            List<Produto> listaParaListar = new List<Produto>();

            while ((line = file.ReadLine()) != null)
            {
                Produto produto = JsonConvert.DeserializeObject<Produto>(line);
                listaParaListar.Add(produto);
            }
            file.Close();
            return listaParaListar;

            //qnd for usar isso é só escolher a lista que deseja para receber essa por exemplo:
            //listaProdutos = File.LerDocumentoProdutosJson(localJson);
        }

        //static public List<Produto> VerificarJson(String local) { 
        //if
        //}

    }
}
