using EfCore.BLL.CrudOperation.Interfaces;

namespace EfCore.BLL.CrudOperation.Implementation
{
    public class CrudOperationFactory : ICrudOperatonFactory
    {
        public Task<ICreate> Create()
        {
            throw new NotImplementedException();
        }

        public Task<IDelete> Delete()
        {
            throw new NotImplementedException();
        }

        public Task<IRead> Read()
        {
            throw new NotImplementedException();
        }

        public Task<IUpdate> Update()
        {
            throw new NotImplementedException();
        }

        public Task<IAuth> Login()
        {
            throw new NotImplementedException();
        }
    }
}
