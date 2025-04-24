using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.ServiceModels
{
   public class PersonServiceModel
    {
        public void Post(Person person) 
        {
            using (var Context = new FinalProjectDbContext())
            {
                try
                {
                    Context.Add(person);
                    Context.SaveChanges();
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

                    public void Edit(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    var personFind = context.Person.Find(person.Id);
                    if (personFind != null)
                    {
                        personFind.Id = person.Id;
                        personFind.FirstName = person.FirstName;
                        personFind.LastName = person.LastName;
                        personFind.NationalId = person.NationalId;
                        context.SaveChanges();
                    }
                }
                catch (Exception e)
                {
                    throw new AggregateException("Error");
                }

            }


        }

        public void Delete(Person person)
        {
            using (var context = new FinalProjectDbContext())
            {
                try
                {
                    context.Person.Remove(person);
                    context.SaveChanges();
                }
                catch (Exception e)
                {
                    throw new AggregateException("Error");
                }
            }
        }

    }
    
}
