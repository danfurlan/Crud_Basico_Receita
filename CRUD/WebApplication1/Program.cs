using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication1.Models;

namespace WebApplication1.Tests
{
    [TestClass]
    public class ClasseReceitaTestes
    {
        [TestMethod]
        public void CriarReceitaTeste()
        {
            var receita = new ClasseReceita
            {
                Id = 1,
                Nome = "Receita de Bolo",
                Ingredientes = "Farinha, Ovos, Açúcar",
                Procedimento = "Misturar os ingredientes e assar"
            };

            var receitasrepo = new ReceitasRepositorio();
            receitasrepo.CriarReceita(receita);
            receitasrepo.ObterReceitaPorId(1);

            Assert.AreEqual("Receita de Bolo", receita.Nome);
            Assert.AreEqual("Farinha, Ovos, Açúcar", receita.Ingredientes);
            Assert.AreEqual("Misturar os ingredientes e assar", receita.Procedimento);
        }

        [TestMethod]
        public void LerReceita()
        {
            var receita = new ClasseReceita
            {
                Id = 1,
                Nome = "Receita de Bolo",
                Ingredientes = "Farinha, Ovos, Açúcar",
                Procedimento = "Misturar os ingredientes e assar"
            };

            //Criar metodo de teste
        
            Assert.AreEqual("Receita de Bolo", receita.Nome);
            Assert.AreEqual("Farinha, Ovos, Açúcar", receita.Ingredientes);
            Assert.AreEqual("Misturar os ingredientes e assar", receita.Procedimento);
        }

         [TestMethod]
        public void LerTodasReceitas()
        {
            var receita = new ClasseReceita
            {
                Id = 1,
                Nome = "Receita de Bolo",
                Ingredientes = "Farinha, Ovos, Açúcar",
                Procedimento = "Misturar os ingredientes e assar"
            };
            var receita2 = new ClasseReceita
            {
                Id = 2,
                Nome = "Receita de coxinha",
                Ingredientes = "Farinha, Ovos, frango desfiado",
                Procedimento = "Misturar os ingredientes e fritar"
            };

            //Criar metodo de teste
        
            Assert.AreEqual("Receita de Bolo", receita.Nome);
            Assert.AreEqual("Farinha, Ovos, Açúcar", receita.Ingredientes);
            Assert.AreEqual("Misturar os ingredientes e assar", receita.Procedimento);
            Assert.AreEqual("Receita de coxinha", receita2.Nome);
            Assert.AreEqual("Farinha, Ovos, frango desfiado", receita2.Ingredientes);
            Assert.AreEqual("Misturar os ingredientes e fritar", receita2.Procedimento)

        }

       
        [TestMethod]
        public void AtualizarReceita()
        {
            var receita = new ClasseReceita
            {
                Id = 1,
                Nome = "Receita de Bolo",
                Ingredientes = "Farinha, Ovos, Açúcar",
                Procedimento = "Misturar os ingredientes e assar"
            };

            //Criar metodo de teste
        
            Assert.AreEqual("Receita de coxinha", receita.Nome);
            Assert.AreEqual("Farinha, Ovos, frango desfiado", receita.Ingredientes);
            Assert.AreEqual("Misturar os ingredientes e fritar", receita.Procedimento);
        }

        [TestMethod]
        public void DeletarReceita()
        {
            var receita = new ClasseReceita
            {
                Id = 1,
                Nome = "Receita de Bolo",
                Ingredientes = "Farinha, Ovos, Açúcar",
                Procedimento = "Misturar os ingredientes e assar"
            };

            //Criar metodo de teste
        
            Assert.AreEqual(null , receita.Id);

        }

       
       
    }
}