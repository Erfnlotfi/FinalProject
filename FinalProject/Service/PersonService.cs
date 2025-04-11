using Model;
using Model.DomainModels;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
   public class PersonService
    {
     private readonly PersonServiceModel _personServiceModel;
        public PersonService()
        {
            _personServiceModel = new PersonServiceModel();
        }
        public List<Person> GetAll()
        {
            var persons = _personServiceModel.SelectAll();
            var getPersonDto = new List<GetPersonDto>();
            foreach (var item in persons)
            {
                var gpd = new GetPersonDto()
                {
                    Id = item.Id,
                    FirstName = item.FirstName,
                    LastName = item.LastName,
                    Nationalid = item.NationalId,
                };
                getPersonDto.Add(gpd);
            }
            return persons;
        }
    }
}
