﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Poetry.Poetry
{
    public interface  ITranslationAppService : ICrudAppService< //Defines CRUD methods
           TranslationDto, //Used to show books
           Guid, //Primary key of the book entity
           PagedAndSortedResultRequestDto, //Used for paging/sorting
           TranslationDto>
    {
        public IActionResult getTranslationMyid([FromQuery] string Myid);
    }
}
