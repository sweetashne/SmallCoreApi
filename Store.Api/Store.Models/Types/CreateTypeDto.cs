﻿using System.ComponentModel.DataAnnotations;
using Store.Models.Base;

namespace Store.Models.Types
{
    public class CreateTypeDto : ICreateEntityDto
    {
        [Required]
        [StringLength(10)]
        public string Code { get; set; }
        [StringLength(200)]
        public string Description { get; set; }
    }
}