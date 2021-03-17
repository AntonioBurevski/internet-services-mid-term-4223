using MidTerm.Models.Models.Question;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Services.Abstraction
{
    public interface IQuestionService
    {
        Task<IEnumerable<QuestionModelBase>> Get();
        Task<QuestionModelExtended> Get(int id);
        Task<QuestionModelBase> Insert(QuestionCreateModel model);
        Task<QuestionModelBase> Update(QuestionUpdateModel model);
        Task<bool> Delete(int id);
    }
}
