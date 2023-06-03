using BlogCore.Models;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IArticuloRepository : IRepository<Articulo>
    {
        IEnumerable<SelectListItem> GetListaArticulos();

        void Update(Articulo articulo);
    }
}
