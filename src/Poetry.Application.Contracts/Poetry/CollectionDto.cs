using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poetry.Poetry
{
    public class CollectionDto : AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }

        
        public string MyId { get; set; }
    }
}
