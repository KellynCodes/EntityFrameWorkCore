namespace EfCore.BLL.CrudOperation.Interfaces
{
    public interface ICrudOperatonFactory
    {
        Task<ICreate> Create();
        Task<IRead> Read();
        Task<IUpdate> Update();
        Task<IDelete> Delete();
        Task<IAuth> Login();
    }
}
