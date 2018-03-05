using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SuggestionBox.Models
{
    public class SuggestionModel
    {
        [Key]
        public int SuggesitonID { get; set; }

        public string Topic { get; set; }
        public string Suggestion { get; set; }



    }
}