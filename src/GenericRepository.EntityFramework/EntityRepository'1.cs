﻿using System.Data.Entity;

namespace GenericRepository.EntityFramework {
    
    /// <summary>
    /// IEntityRepository implementation for DbContext instance where the TId type is Int32.
    /// </summary>
    /// <typeparam name="TEntity">Type of entity</typeparam>
    public class EntityRepository<TEntity> : EntityRepository<TEntity, int> 
        where TEntity : class, IEntity<int> {

        public EntityRepository(DbContext dbContext) : base(dbContext) { 

        }
    }
}