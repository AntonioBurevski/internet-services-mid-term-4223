using AutoMapper;
using MidTerm.Data.Entities;
using MidTerm.Models.Models.Option;
using System;
using System.Collections.Generic;
using System.Text;

namespace MidTerm.Models.Profiles
{
    public class OptionProfile : Profile
    {
        public OptionProfile()
        {
            CreateMap<Option, OptionModelBase>()
                .ReverseMap();

            CreateMap<Option, OptionModelExtended>();

            CreateMap<OptionCreateModel, Option>();
            CreateMap<OptionUpdateModel, Option>();
        }
    }
}
