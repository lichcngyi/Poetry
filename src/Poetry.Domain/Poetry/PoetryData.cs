using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Poetry.Poetry
{
    public class PoetryData: AuditedAggregateRoot<Guid>
    {
        [Column(TypeName = "nvarchar(20)")]
        public string MyId { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Title { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Author { get; set; }
        [Column(TypeName = "nvarchar(20)")]
        public string Period { get; set; }
        public string Content { get; set; }

        public string List { get; set; }
         
    }
}
