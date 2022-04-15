using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Poetry.Poetry
{
    public class Collection : AuditedAggregateRoot<Guid>
    {
        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MyId { get; set; }
    }
}
