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
        public CollectionAppService(IRepository<Collection, Guid> repository) : base(repository)
        {
        }
    }
}
