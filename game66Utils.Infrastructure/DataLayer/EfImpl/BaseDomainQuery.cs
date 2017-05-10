﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using JetBrains.Annotations;

namespace game66Utils.Infrastructure.DataLayer.EfImpl
{
    public interface IInitByContext
    {
        void Init(DbContext context);
    }

    public abstract class BaseDomainQuery<TDomain, TState> : IInitByContext, IBaseDomainQuery<TDomain> where TDomain : class where TState : class
    {
        public void Init(DbContext context)
        {
            _query = context.Set<TState>();
            // ReSharper disable once VirtualMemberCallInConstructor
            //TODO do not call this in constructor
            Include(_query);
        }

        private IQueryable<TState> _query;

        protected void ApplyQuery(Func<IQueryable<TState>, IQueryable<TState>> applyQueryFunc)
        {
            _query = applyQueryFunc(_query);
        }

        protected abstract TDomain ToModel(TState state);
        
        protected abstract IQueryable<TState> Include(IQueryable<TState> query);

        public void ReadOnly()
        {
            ApplyQuery(x=>x.AsNoTracking());
        }

        public async Task<List<TDomain>> ToList()
        {
            var list = await _query.ToListAsync();

            return list.Select(ToModel).ToList();
        }

        public async Task<bool> Any()
        {
            return await _query.AnyAsync();
        }

        [CanBeNull]
        public async Task<TDomain> First()
        {
            var state = await _query.FirstOrDefaultAsync();
            return state == null ? (TDomain)null : ToModel(state);
        }

        public async Task<int> Count()
        {
            return await _query.CountAsync();
        }

    }
}