using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Models.Models.Question
{
    public class QuestionModelExtended
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }

        public IEnumerable<QuestionModelBase> Options { get; set; }
    }
}
