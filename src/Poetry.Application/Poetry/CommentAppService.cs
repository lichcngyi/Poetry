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
    public class CommentAppService :
        CrudAppService<
            Comment, //The Book entity
            CommentDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            CommentDto>, ICommentAppService
    {
        public CommentAppService(IRepository<Comment, Guid> repository) : base(repository)
        {


        }

        public IActionResult getCommentMyid([FromQuery] string Myid)
        {
            return new JsonResult( Repository.Where(p=>p.MyId == Myid).ToList());
        }
        public IActionResult getCommentId([FromQuery] Guid Id)
        {
            return new JsonResult(Repository.Where(p => p.Id == Id).ToList());
        }
    }
}
