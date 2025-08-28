using System;
using System.Collections;
using System.Linq;
using AutoMapper;
using AutoMapper.QueryableExtensions;

namespace SurveyReportRE.Models
{
    public class CustomMapper : IMapper
    {
        private Mapper _mapper;

        public CustomMapper(Mapper mapper)
        {
            _mapper = mapper;
        }

        public TResult MapTo<TResult>(IEnumerable source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }
            return (TResult)_mapper.Map(source, source.GetType(), typeof(TResult));
        }

        public TResult MapTo<TResult>(object source)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            return (TResult)_mapper.Map(source, source.GetType(), typeof(TResult));
        }

        public TResult MapToInstance<TResult>(object source, TResult dest)
        {
            if (source == null)
            {
                throw new ArgumentNullException();
            }

            return (TResult)_mapper.Map(source, dest, source.GetType(), typeof(TResult));
        }

        public IQueryable<TDestination> MapToIQueryable<TSource, TDestination>(IQueryable<TSource> query)
        {
            return (IQueryable<TDestination>)query.ProjectTo(typeof(TDestination), _mapper.ConfigurationProvider);
        }
    }
}
