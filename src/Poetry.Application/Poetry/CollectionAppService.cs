using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Poetry.Poetry
{
    public class CollectionAppService :
        CrudAppService<
            Collection, //The Book entity
            CollectionDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CollectionDto>, ICollectionAppService
    {
        public IRepository<PoetryData, Guid> _poetry;
        public CollectionAppService(IRepository<Collection, Guid> repository, IRepository<PoetryData, Guid> poetry) : base(repository)
        {
            _poetry = poetry;
        }
        [HttpGet]
        public IActionResult GetCollectionUserName([FromQuery] string UserName)
        {

            return new JsonResult(Repository.Where(p => p.UserName == UserName).Select(x => new
            {
                id=x.Id,
                userName = x.UserName,
                poetry = _poetry.First(u=>u.MyId==x.MyId)
            }).ToList()); ;
        }
    }
}
