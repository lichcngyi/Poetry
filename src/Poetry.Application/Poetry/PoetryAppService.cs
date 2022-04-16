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
        IRepository<PoetryData, Guid> _repository;
        IRepository<PoetryClassify, Guid> _poetryClassify;
        public PoetryAppService(IRepository<PoetryData, Guid> repository, IRepository<PoetryClassify, Guid> poetryClassify) : base(repository)
        {
            _repository = repository;
            _poetryClassify=poetryClassify;
        }
        [HttpGet]
        public IActionResult getPoetryID([FromQuery] string Myid)
        {
            return new JsonResult(_repository.Where(p => p.MyId == Myid).ToList());
        }
        [HttpGet]
        public IActionResult getPoetryPeriod()
        {
            return new JsonResult(_repository.GroupBy(p => p.Period).Select(p => new
            {
                Period = p.Key
            }).ToList());
        }
        [HttpGet]
        public IActionResult getPoetryPeriodCx([FromQuery] string Period)
        {
            return new JsonResult(_repository.Where(p => p.Period == Period).Select(p => new
            {
                Title=p.Title,
                Author=p.Author,
                Period=Period,
                MyId=p.MyId
            }).ToList());
        }
        public IActionResult getPoetryOrder()
        {
            return new JsonResult(_repository.OrderBy(p => p.CreationTime).Take(20).ToList());
        }



        public IActionResult getPoetryClassMyType([FromQuery] string MyType)
        {
            return new JsonResult(_poetryClassify.Where(p => p.MyType == MyType).Select(p=>new
            {
                Title = _repository.First(x=>x.MyId==p.MyId).Title,
                Author = _repository.First(x => x.MyId == p.MyId).Author,
                Period = _repository.First(x => x.MyId == p.MyId).Period,
                MyId = _repository.First(x => x.MyId == p.MyId).MyId,
            }).ToList());
        }

        
    }
}
