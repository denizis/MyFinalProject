using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        ICustomerDal _customerdal;
        public CustomerManager(ICustomerDal customerdal)
        {


            _customerdal = customerdal;

        }

        public void Add(Customer entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Customer entity)
        {
            throw new NotImplementedException();
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Customer> GetAll()
        {
            return _customerdal.GetAll();
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Customer entity)
        {
            throw new NotImplementedException();
        }
    }
}
