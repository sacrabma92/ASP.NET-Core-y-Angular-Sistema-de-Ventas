using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS.Infraestructure.Persistences.Interfaces
{
    public interface IUnitOfWork : IDisposable 
    {
        //Declaración o matricula de nuestas interfaces a nivel de repositorio
        ICategoryRepository Category { get; }
        void SaveChanges();
        Task SaveChagesAsyn();
    } 
}
