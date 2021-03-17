using MidTerm.Models.Models.Option;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Services.Abstraction
{
    public interface IOptionService
    {
        Task<IEnumerable<OptionModelBase>> Get();
        Task<OptionModelExtended> Get(int id);
        Task<OptionModelBase> Insert(OptionCreateModel model);
        Task<OptionModelBase> Update(OptionUpdateModel model);
        Task<bool> Delete(int id);
    }
}
