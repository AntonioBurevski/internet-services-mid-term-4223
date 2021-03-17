using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MidTerm.Data;
using MidTerm.Data.Entities;
using MidTerm.Models.Models.Option;
using MidTerm.Services.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm.Services.Services
{
    public class OptionService : IOptionService
    {
        private readonly MidTermDbContext _context;
        private readonly IMapper _mapper;

        public OptionService(MidTermDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<OptionModelBase>> Get()
        {
            var options = await _context.Options.ToListAsync();
            return _mapper.Map<IEnumerable<OptionModelBase>>(options);
        }

        public async Task<OptionModelExtended> Get(int id)
        {
            var option = await _context.Options
                .Include(o => o.Question)
                .FirstOrDefaultAsync(o => o.Id == id);

            return _mapper.Map<OptionModelExtended>(option);
        }

        public async Task<OptionModelBase> Insert(OptionCreateModel model)
        {
            var entity = _mapper.Map<Option>(model);

            await _context.Options.AddAsync(entity);
            await SaveAsync();

            return _mapper.Map<OptionModelBase>(entity);
        }

        public async Task<OptionModelBase> Update(OptionUpdateModel model)
        {
            var entity = _mapper.Map<Option>(model);

            _context.Options.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;

            await SaveAsync();

            return _mapper.Map<OptionModelBase>(entity);
        }

        public async Task<bool> Delete(int id)
        {
            var entity = await _context.Options.FindAsync(id);
            _context.Options.Remove(entity);
            return await SaveAsync() > 0;
        }

        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
