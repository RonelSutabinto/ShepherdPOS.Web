//==============================================================================================================================
//Creates UpdateProductCategoryDto dto Model for the ShepherdPO database =======================================================
//===Try this link for more detailshttps://www.entityframeworktutorial.net/entity-relationships.aspx========================
//==============================================================================================================================

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