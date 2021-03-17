using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Models.Models.Option
{
    public class OptionModelBase
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public int? Order { get; set; }
    }
}
