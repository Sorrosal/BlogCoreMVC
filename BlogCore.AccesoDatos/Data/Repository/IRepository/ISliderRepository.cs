using BlogCore.Models;
using System.Web.Mvc;

namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface ISliderRepository : IRepository<Slider>
    {
        IEnumerable<SelectListItem> GetListaSliders();

        void Update(Slider slider);
    }
}
