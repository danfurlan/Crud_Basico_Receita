using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ClasseReceita
{
    // Modelo de Receitas com get e set 
    public class Receitas
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Ingredientes { get; set; }
        public string Procedimento {get; set;}
    }

    // Referencia para o Banco de Dados

    public class AppDbContext : DbContext
    {
        public DbSet<Receitas> Receita { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }

    public class ReceitasRepositorio
    {
        // Criar um novo
        public void CriarReceita(Receitas receitas)
        {
            using (var contexto = new AppDbContext())
            {
                contexto.Receita.Add(receitas);
                contexto.SaveChanges();
            }
        }


        // Ler todos
        public List<Receitas> ObterTodasReceitas()
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Receitas.ToList();
            }
        }

        // Ler um
        public Receitas ObterReceitaPorId(int id)
        {
            using (var contexto = new AppDbContext())
            {
                return contexto.Receita.Find(id);
            }
        }

        // Atualizar um
        public void AtualizarReceita(Receitas receitas)
        {
            using (var contexto = new AppDbContext())
            {
                contexto.Produtos.Update(produto);
                contexto.SaveChanges();
            }
        }

        // Deletar um
        public void DeletarReceita(int id)
        {
            using (var contexto = new AppDbContext())
            {
                var produto = contexto.Receita.Find(id);
                if (produto != null)
                {
                    contexto.Produtos.Remove(produto);
                    contexto.SaveChanges();
                }
            }
        }
    }

}