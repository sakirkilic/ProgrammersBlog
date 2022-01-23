using ProgrammersBlog.Shared.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ProgrammersBlog.Shared.Data.Abstract
{
    public interface IEntityRepository<T> where T: class, IEntity, new() // T bir class , IEntity ve new'lenebilir olmalı.
	{
		Task<T> GetAsync(Expression<Func<T,bool>> predicate,params Expression<Func<T,object>>[] includeProperties );
		Task<IList<T>> GetAllAsync(Expression<Func<T, bool>> predicate=null, params Expression<Func<T, object>>[] includeProperties);// pradicate null verilir ise yani filtre göndermez isek T tipinde ki nesnenin bize hepsini dönecek. Defaultta null vermezsek filtre yollamamız şarttır.
		Task AddAsync(T entity);
		Task UpdateAsync(T entity);
		Task DeleteAsync(T entity);
		Task<bool> AnyAsync(Expression<Func<T, bool>> predicate);
		Task<int> CountAsync(Expression<Func<T, bool>> predicate);

	}
}


// Dapper, Ado.net entityframework yapıları için kullanabiliriz.