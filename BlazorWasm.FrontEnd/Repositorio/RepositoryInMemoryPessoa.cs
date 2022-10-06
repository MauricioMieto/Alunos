using BlazorWasm.Compartilhado.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorWasm.FrontEnd.Repositorio
{
    public class RepositoryInMemoryPessoa : IRepository<Pessoa>
    {
        public List<Pessoa> ListaPessoas { get; set; } = new List<Pessoa>();
        private static int idBase = 0;

        public Task Add(Pessoa item)
        {
            item.Id = idBase++;
            ListaPessoas.Add(item);
            return Task.CompletedTask;
        }

        public Task<int> AddAndGetId(Pessoa item)
        {
            item.Id = idBase++;
            ListaPessoas.Add(item);
            return Task.FromResult(item.Id);
        }

        public Task Delete(int Id)
        {
            var itemToRemove = ListaPessoas.Find(x => x.Id == Id);
            ListaPessoas.Remove(itemToRemove);
            return Task.CompletedTask;
        }

        public Task<List<Pessoa>> Get()
        {
            return Task.FromResult(ListaPessoas);
        }

        public Task<Pessoa> Get(int id)
        {
            var item = ListaPessoas.Find(x => x.Id == id);       
            return Task.FromResult(item);
        }

        public Task Update(Pessoa item)
        {
            int index = ListaPessoas.IndexOf
                (ListaPessoas.First(o => o.Id == item.Id));
            ListaPessoas[index] = item;
            return Task.CompletedTask;
        }
    }
}
