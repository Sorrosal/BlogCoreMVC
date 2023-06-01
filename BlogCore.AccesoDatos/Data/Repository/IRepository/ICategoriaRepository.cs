using BlogCore.Models;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface ICategoriaRepository : IRepository<Categoria>
    {
        IEnumerable<SelectListItem> GetListaCategorias();

        void Update(Categoria categoria);
    }
}
