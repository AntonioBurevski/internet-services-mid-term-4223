using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MidTerm.Models.Models.Question
{
    public class QuestionUpdateModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        [MaxLength(800)]
        public string Text { get; set; }
        [Required]
        [MaxLength(800)]
        public string Description { get; set; }
    }
}
