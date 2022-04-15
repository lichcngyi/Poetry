using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Poetry.Poetry
{
    public class Vote : AuditedAggregateRoot<Guid>
    {
        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }

        
        public Guid TranslationID { get; set; }
        
        public int Grade { get; set; }
    }
}
