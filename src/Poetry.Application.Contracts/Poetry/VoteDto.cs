using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poetry.Poetry
{
    public class VoteDto : AuditedEntityDto<Guid>
    {
        public string UserName { get; set; }

        public Guid TranslationID { get; set; }

        public int Grade { get; set; }
    }
}
