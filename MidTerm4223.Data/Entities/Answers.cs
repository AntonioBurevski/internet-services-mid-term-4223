using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MidTerm.Data.Entities
{
    public class Answers
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OptionId { get; set; }

        [ForeignKey("OptionId")]
        public virtual Option Option { get; set; }

        [ForeignKey("UserId")]
        public virtual SurveyUser User { get; set; }
    }
}
