using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCore.BLL.CrudOperation.Interfaces
{
    public interface IDelete
    {
        Task Del(int id);
    }
}
