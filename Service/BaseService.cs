using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class BaseService
    {
        public BaseService()
        {
        }

        protected TEntity mapTo<TSource, TEntity>(TSource source)
        {
            try
            {
                TEntity item = (TEntity)Mapper.Map<TSource, TEntity>(source);
                return item;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }
    }
}
