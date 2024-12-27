using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TouristPlaces.Models
{
    public class TouristPlace
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int TouristPlaceId { set; get; }
        [Required]
        public string TouristPlaceName { set; get; }
        [Required]
        public string Description { set; get; }
        [Required]
        public string Location { set; get; }
        [Required]
        public bool Status { set; get; }
        [Required]
        public string Moreinfo { set; get; }
        [Required]
        public string ImagePath { set; get; }
        [NotMapped]
        public HttpFileCollectionBase Files { set; get; }
    }
}