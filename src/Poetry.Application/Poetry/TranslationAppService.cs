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
    public class TranslationAppService :
        CrudAppService<
            Translation, //The Book entity
            TranslationDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            TranslationDto>, ITranslationAppService
    {
        IRepository<Vote, Guid> _votes;
        public TranslationAppService(IRepository<Translation, Guid> repository, IRepository<Vote, Guid> votes) : base(repository)
        {
            _votes = votes;
        }

        [HttpGet]
        public IActionResult getTranslationMyid([FromQuery] string Myid)
        {
            var arr = Repository.Where(p => p.MyId == Myid && p.Valid == 1).Select(p => new
            {
                Id=p.Id,
                MyId = p.MyId,
                RelatedTranslation = p.RelatedTranslation,
                CreationTime = p.CreationTime,
                Grade = _votes.Where(x => x.TranslationID == p.Id).Sum(u => u.Grade),
            }).OrderByDescending(p => p.CreationTime).Take(5).ToList();

            var arr2 = Repository.Where(p => p.MyId == Myid && p.Valid == 1).Select(p => new
            {
                Id = p.Id,
                MyId = p.MyId,
                RelatedTranslation = p.RelatedTranslation,
                CreationTime = p.CreationTime,
                Grade = _votes.Where(x => x.TranslationID == p.Id).Sum(u => u.Grade),
            }).OrderByDescending(p => p.Grade).Take(5).ToList();

            arr2.AddRange(arr);
            return new JsonResult(arr2);
        }





    }
}
