using Mobiliva.Core.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mobiliva.Entities.Dtos
{
    public class ProductDto : IDto
    {
        public int Id { get; set; }

        [DisplayName("Açıklama")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden fazla olmalıdır")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden az olmalıdır")]
        public string Description { get; set; }

        [DisplayName("Kategori Bilgisi")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden fazla olmalıdır")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden az olmalıdır")]
        public string Category { get; set; }

        [DisplayName("Birim Açıklaması")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        [MinLength(2, ErrorMessage = "{0} {1} karakterden fazla olmalıdır")]
        [MaxLength(500, ErrorMessage = "{0} {1} karakterden az olmalıdır")]
        public string Unit { get; set; }

        [DisplayName("Fiyat")]
        [Required(ErrorMessage = "{0} alanı boş geçilemez")]
        public int UnitPrice { get; set; }

    }
}
