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
    public class TranslationAppService :
        CrudAppService<
            Translation, //The Book entity
            TranslationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            TranslationDto>, ITranslationAppService
    {
        public TranslationAppService(IRepository<Translation, Guid> repository) : base(repository)
        {
        }
    }
}
