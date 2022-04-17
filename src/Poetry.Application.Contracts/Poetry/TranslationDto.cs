using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poetry.Poetry
{
    public class TranslationDto : AuditedEntityDto<Guid>
    {

        public string MyId { get; set; }
        
        public string RelatedTranslation { get; set; }

        public int Valid { get; set; }
    }
}
