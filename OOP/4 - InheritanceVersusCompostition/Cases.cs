using System;

namespace OOP
{
    #region Case 1

    public class NaturalPerson : Person
    {
        //Tax Identification Number
        public string Nif { get; set; }
    }

    public class NaturalPerson2
    {
        public Person Person { get; set; }
        public string Nif { get; set; }
    }

    public class InheritanceCompositionTest
    {
        public InheritanceCompositionTest()
        {
            var inheritancePerson = new NaturalPerson
            {
                Name = "Denis",
                DateOfBirth = DateTime.Now,
                Nif = "32165498765"
            };

            var compositionPerson = new NaturalPerson2
            {
                Person = new Person
                {
                    Name = "Denis",
                    DateOfBirth = DateTime.Now,
                },
                Nif = "32165498765"
            };

            var inheritanceName = inheritancePerson.Name;
            var compositionName = compositionPerson.Person.Name;
        }
    }

    #endregion

    #region Case 2

    public interface IRepository<T>
    {
        void Add(T obj);

        void Delete(T obj);
    }

    public interface IPersonRepository
    {
        void Add(Person obj);
    }

    public class Repository<T> : IRepository<T>
    {
        public void Add(T obj)
        {

        }

        public void Delete(T obj)
        {

        }
    }

    public class PersonInheritanceRepository : Repository<Person>, IPersonRepository
    {

    }

    public class PersonCompositionRepository : IPersonRepository
    {
        private readonly IRepository<Person> _personRepository;

        public PersonCompositionRepository(IRepository<Person> personRepository)
        {
            _personRepository = personRepository;
        }

        public void Add(Person obj)
        {
            _personRepository.Add(obj);
        }
    }

    public class InheritanceCompositionTest2
    {
        public InheritanceCompositionTest2()
        {
            var repoH = new PersonInheritanceRepository();
            repoH.Add(new Person());
            repoH.Delete(new Person());

            var repoC = new PersonCompositionRepository(new Repository<Person>());
            repoC.Add(new Person());
        }
    }

    #endregion
}
