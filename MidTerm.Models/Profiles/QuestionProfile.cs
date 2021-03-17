using AutoMapper;
using MidTerm.Data.Entities;
using MidTerm.Models.Models.Question;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Models.Profiles
{
    public class QuestionProfile : Profile
    {
        public QuestionProfile()
        {
            CreateMap<Question, QuestionModelBase>()
                .ReverseMap();

            CreateMap<Question, QuestionModelExtended>();

            CreateMap<QuestionCreateModel, Question>();
            CreateMap<QuestionUpdateModel, Question>();
        }
    }
}
