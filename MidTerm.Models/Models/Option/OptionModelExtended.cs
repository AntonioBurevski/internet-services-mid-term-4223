using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace MidTerm.Models.Models.Option
{
    public class OptionModelExtended
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? Order { get; set; }
        public int QuestionId { get; set; }
    }
}
