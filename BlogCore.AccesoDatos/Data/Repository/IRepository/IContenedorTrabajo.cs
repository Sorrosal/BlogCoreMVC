namespace BlogCore.AccesoDatos.Data.Repository.IRepository
{
    public interface IContenedorTrabajo : IDisposable
    {
        ICategoriaRepository Categoria { get; }
        IArticuloRepository Articulo { get; }
        ISliderRepository Slider { get; }
        IUsuarioRepository Usuario { get; }

        //Aquí se deben de ir agregando los diferentes repositorios
        void Save();
    }
}
