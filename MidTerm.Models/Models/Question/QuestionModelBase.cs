using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Models.Models.Question
{
    public class QuestionModelBase
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public string Description { get; set; }
    }
}
