using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poetry.Poetry
{
    public class CommentDto : AuditedEntityDto<Guid>
    {
        [StringLength(20)]
        public string UserName { get; set; }
        public Guid CommentId { get; set; }

        [StringLength(20)]
        public string MyId { get; set; }

        //[Column(TypeName = "nvarchar(max)")]
        public string Content { get; set; }
    }
}
