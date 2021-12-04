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
    public class PoetryAppService :
        CrudAppService<
            PoetryData, //The Book entity
            PoetryDataDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            PoetryDataDto>, IPoetryAppService
    {
        public PoetryAppService(IRepository<PoetryData, Guid> repository) : base(repository)
        {
        }
    }
}
