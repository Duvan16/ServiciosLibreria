using MongoDB.Driver;

namespace Servicios.api.Libreria.Core.Entities.ContextMongoDB
{
    public interface IAutorContext
    {
        IMongoCollection<Autor> Autores { get; }
    }
}
