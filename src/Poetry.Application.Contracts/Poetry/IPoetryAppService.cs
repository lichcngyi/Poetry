using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Poetry.Poetry
{
    public interface IPoetryAppService:
        ICrudAppService< //Defines CRUD methods
            PoetryDataDto, //Used to show books
            Guid, //Primary key of the book entity
            PagedAndSortedResultRequestDto, //Used for paging/sorting
            PoetryDataDto> 
    {
        public IActionResult getPoetryID([FromQuery] string Myid);
        public IActionResult getPoetryPeriod();
        public IActionResult getPoetryPeriodCx([FromQuery] string Period);
        public IActionResult getPoetryOrder();
        public IActionResult getPoetrySearch([FromQuery] string Search);
        public IActionResult getPoetryAuthorAll();
        public IActionResult getPoetryAuthor([FromQuery] string Author);
        public IActionResult getPoetryClassMyType([FromQuery] string MyType);
        
    }
}
