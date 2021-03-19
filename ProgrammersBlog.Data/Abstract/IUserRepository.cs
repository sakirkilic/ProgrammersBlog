using ProgrammersBlog.Entities.Concrete;
using ProgrammersBlog.Shared.Data.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammersBlog.Data.Abstract
{
	public interface IUserRepository : IEntityRepository<User>
	{
		//Task<User> GetEmailAsync(Expression<Func<User, bool>> predicate, params Expression<Func<User, object>>[] includeProperties);
	}
}
