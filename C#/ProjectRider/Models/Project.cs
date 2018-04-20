namespace ProjectRider.Models
{
    using System.ComponentModel.DataAnnotations;

    public class Project
    {
        
        public int Id { get; set; }
        
        [Required]
        [MinLength(1)]
        public string Title { get; set; }

        [Required]
        [MinLength(1)]
        public string Description { get; set; }

        [Required]
        public int Budget { get; set; }
    }
}
