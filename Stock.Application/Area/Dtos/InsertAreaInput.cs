using System.ComponentModel.DataAnnotations;

namespace Stock.Area.Dtos
{
    public class InsertAreaInput
    {
        [Required]
        [MaxLength(Areas.Area.MaxIDLength)]
        public string Id { get; set; }

        [Required]
        [MaxLength(Areas.Area.MaxNameLength)]
        public string Name { get; set; }

        public string ParentId { get; set; }
    }
}
