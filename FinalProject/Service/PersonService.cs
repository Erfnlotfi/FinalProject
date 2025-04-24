using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Model.DomainModels;
using Model.ServiceModels;
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
        public void Post(PostPersonDto dto)
        {
            var Person = new Person()
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                NationalId = dto.Nationalid,
            };
            _personServiceModel.Post(Person);
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
        public void Edit(EditPersonDto editPersonDto)
        {
            var person = new Person()
            {
                Id = editPersonDto.Id,
                FirstName = editPersonDto.FirstName,
                LastName = editPersonDto.LastName,
                NationalId = editPersonDto.NationalId,
            };
            _personServiceModel.Edit(person);
        }

        public void Delete(DeletePersonDto DeletePersonDto)
        {
            var person = new Person()
            {
                Id = DeletePersonDto.Id
            };
            _personServiceModel.Delete(person);
        }
    }
}

