using System.ComponentModel.DataAnnotations;

namespace Stock.Area.Dtos
{
    public class UpdateAreaInput
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
