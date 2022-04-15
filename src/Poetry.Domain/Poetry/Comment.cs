using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Domain.Entities.Auditing;

namespace Poetry.Poetry
{
    public class Comment : AuditedAggregateRoot<Guid>
    {
        [Column(TypeName = "nvarchar(20)")]
        public string UserName { get; set; }
        public Guid CommentId { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string MyId { get; set; }

        [Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; }
    }
}
