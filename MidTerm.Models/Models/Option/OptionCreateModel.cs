using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MidTerm.Models.Models.Option
{
    public class OptionCreateModel
    {
        [Required]
        public string Text { get; set; }
        public int? Order { get; set; }
        public int QuestionId { get; set; }
    }
}
