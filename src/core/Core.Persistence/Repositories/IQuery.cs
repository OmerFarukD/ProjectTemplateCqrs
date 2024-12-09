using System.Linq.Expressions;
using Core.Persistence.Extensions;

namespace Core.Persistence.Repositories;

public interface IQuery<T>
{
    IQueryable<T> Query();
}

