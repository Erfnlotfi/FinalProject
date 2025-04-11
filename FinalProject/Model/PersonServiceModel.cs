using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
   public class PersonServiceModel
    {
        public List<Person> SelectAll()
        {
            using (var Context = new FinalProjectDbContext())
            {
                try
                {
                    var People = Context.Person.ToList();
                    return People;
                }
                catch (Exception)
                {

                    throw;
                }
                finally
                {
                    if (Context != null)
                        Context.Dispose();
                }
            }

        }
    }
}
