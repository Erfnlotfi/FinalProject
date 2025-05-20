using ApplicationService.Dtos;
using Microsoft.EntityFrameworkCore;
using Model;
using Model.DomainModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationService
{
    public class PersonService(FinalDbContext context)

    {
        private readonly FinalDbContext _context = context;
        public List<GetPersonDto> GetAllPersons()
        {
            return _context.Person
                .Select(p => new GetPersonDto
                {
                    Id = p.Id,
                    FirstName = p.FirstName,
                    LastName = p.LastName,
                    Age = p.Age
                })
                .ToList();
        }

        public GetPersonDto GetPersonById(int id)
        {
            var person = _context.Person.Find(id);
            return person == null ? null : new GetPersonDto
            {
                Id = person.Id,
                FirstName = person.FirstName,
                LastName = person.LastName,
                Age = person.Age
            };
        }

        public void AddPerson(PostPersonDto dto)
        {
            var person = new Person
            {
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                Age = dto.Age
            };
            _context.Person.Add(person);
            _context.SaveChanges();
        }

        public void UpdatePerson(EditPersonDto dto)
        {
            var person = _context.Person.Find(dto.Id);
            if (person != null)
            {
                person.FirstName = dto.FirstName;
                person.LastName = dto.LastName;
                person.Age = dto.Age;
                _context.SaveChanges();
            }
        }

        public void DeletePerson(DeletePersonDto dto)
        {
            var person = _context.Person.Find(dto.Id);
            if (person != null)
            {
                _context.Person.Remove(person);
                _context.SaveChanges();
            }
        }
    }
}
