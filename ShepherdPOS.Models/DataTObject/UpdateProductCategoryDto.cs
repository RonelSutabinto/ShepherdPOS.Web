using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ShepherdPOS.Models.DataTObject
{
    public class UpdateProductCategoryDto
    {
        public int Id { get; set; }

        [Required]
        public string? CategoryName { get; set; }
    }
}