using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;
using ApiBase.Domain.Entities;
using ApiBase.Domain.Repository;

namespace ApiBase.Infrastructure.Repository
{
    public class PersonRepository : ConfigRepository, IPersonRepository
    {
        public Task Add(Person entity)
        {
            string sql =  @"INSERT INTO Person(Name,Email, Photo, Birthdate, WhatsAppNumber)
                            values(@Name, @Email, @Photo, @Birthday, @WhatsAppNumber); select LAST_INSERT_ID();";
            using (var db = GetMySqlConnection())
            {
                entity.Id = 
            }
        }

        public Task Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<List<Person>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Person> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Person>> Search(Expression<Func<Person, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task Update(Person entity)
        {
            throw new NotImplementedException();
        }
    }
}