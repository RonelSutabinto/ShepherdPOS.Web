﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShepherdPOS.Models.DataTO
{
	public class ProductCategoryDto
	{
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string IconCSS { get; set; } = string.Empty;
        
    }
}

