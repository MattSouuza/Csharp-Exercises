using System.Collections.Generic;
using System.IO;
using RoleTopMVC.Models;

namespace RoleTopMVC.Repositories
{
    public class PlanosRepository
    {
        private const string PATH = "Database/Planos.csv";

        public double ObterPrecoDe(string Plano)
        {
            var lista = ObterTodos();
            var preco = 0.0;
            foreach (var item in lista)
            {
                if(item.Nome.Equals(Plano))
                {
                    preco = item.Preco;
                    break;
                }
            }

            return preco;
        }

        public List<Planos> ObterTodos()
        {
            List<Planos> planos = new List<Planos>();

            string[] linhas = File.ReadAllLines(PATH);
            foreach (var linha in linhas)
            {
                Planos p = new Planos();
                string[] dados = linha.Split(";");
                p.Nome = dados[0];
                p.Preco = double.Parse(dados[1]);
                planos.Add(p);
            }

            return planos;
        }
    }
}