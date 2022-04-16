using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Poetry.Poetry
{
    public interface ICollectionAppService : ICrudAppService< //Defines CRUD methods
           CollectionDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CollectionDto>
    {
    }
}
