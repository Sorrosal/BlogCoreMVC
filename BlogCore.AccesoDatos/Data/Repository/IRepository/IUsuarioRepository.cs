using BlogCore.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IUsuarioRepository : IRepository<ApplicationUser>
    {
        void BloquearUsuario(string IdUsuario);
        void DesbloquearUsuario(string IdUsuario);
    }
}
