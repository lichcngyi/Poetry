using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Poetry.Poetry
{
    public class PoetryDataDto:AuditedEntityDto<Guid>
    {
        [Required]
        [StringLength(12)]
        public string MyId { get; set; }
        
        public string Title { get; set; }
       
        public string Author { get; set; }
        
        public string Period { get; set; }
        public string Content { get; set; }

        public string List { get; set; }
    }
}
