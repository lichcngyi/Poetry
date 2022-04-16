using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Poetry.Poetry
{
    public interface ICommentAppService : ICrudAppService< //Defines CRUD methods
           CommentDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           CommentDto>
    {

        public IActionResult getCommentMyid([FromQuery] string Myid);
    }
}
