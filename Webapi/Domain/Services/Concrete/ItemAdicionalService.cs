using System.Collections.Generic;
using Webapi.Domain.Repositorys.Abstract;
using Webapi.Domain.Services.Abstract;
using Webapi.Entities;

namespace Webapi.Domain.Services.Concrete
{
    public class ItemAdicionalService : IItemAdicionalService
    {
        private IItemAdicionalRepository Repository { get; set;}
        public ItemAdicionalService(IItemAdicionalRepository repository)
        {
            this.Repository = repository;
        }

        public List<ItemAdicional> ObterTodos()
        {
            return this.Repository.ObterTodos();
        }
    }
}