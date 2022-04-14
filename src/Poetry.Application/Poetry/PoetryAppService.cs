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
    public class PoetryAppService :
        CrudAppService<
            PoetryData, //The Book entity
            PoetryDataDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            PoetryDataDto>, IPoetryAppService
    {
        IRepository<PoetryClassify, Guid> _poetryClassify;
        IRepository<PoetryData, Guid> _repository;
        public PoetryAppService(IRepository<PoetryData, Guid> repository, IRepository<PoetryClassify, Guid> poetryClassify) : base(repository)
        {
            _repository = repository;
            _poetryClassify = poetryClassify;
        }

        public IActionResult getPoetryID([FromQuery] string Myid)
        {
            return new JsonResult(_repository.Where(p => p.MyId == Myid).ToList());
        }

        public IActionResult getPoetrylx()
        {
            return new JsonResult(_poetryClassify.GroupBy(p => p.MyType).Select(p => new
            {
                MyType = p.Key
            }).ToList());
        }
    }
}
