using System.ComponentModel.DataAnnotations;

namespace RookieShop2.Domain
{
    public class Brand
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

    }
}
