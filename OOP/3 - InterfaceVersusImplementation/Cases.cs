namespace OOP
{
    public interface IRepository
    {
        void Add();
    }

    public class Repository : IRepository
    {
        //public Repository(int a)
        //{

        //}

        public void Add()
        {
            // Add an item
        }
    }

    public class FakeRepository : IRepository
    {
        public void Add()
        {
            // Add an item
        }
    }

    public class ImplementationUse
    {
        public void Process()
        {
            var repository = new Repository();
            repository.Add();
        }
    }

    public class AbstractionUse
    {
        private readonly IRepository _repository;

        public AbstractionUse(IRepository repository)
        {
            _repository = repository;
        }

        public void Process()
        {
            _repository.Add();
        }
    }

    public class InterfaceImplementationTest
    {
        public InterfaceImplementationTest()
        {
            var repoImp = new ImplementationUse();
            repoImp.Process();

            var repoAbs = new AbstractionUse(new Repository());
            repoAbs.Process();

            var repoAbsFake = new AbstractionUse(new FakeRepository());
            repoAbsFake.Process();
        }
    }
}
