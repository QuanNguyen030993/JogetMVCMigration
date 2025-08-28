using System.Collections;
using System.Linq;

namespace SurveyReportRE.Models
{
    public interface IMapper
    {
        TResult MapTo<TResult>(IEnumerable source);

        TResult MapTo<TResult>(object source);

        TResult MapToInstance<TResult>(object source, TResult dest);

        IQueryable<TDestination> MapToIQueryable<TSource, TDestination>(IQueryable<TSource> query);
    }
}
