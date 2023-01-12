using MongoDB.Driver;

namespace mongodot.Data.Interfaces
{
    public interface IGateway
    {
        IMongoDatabase GetMongoDB();
    }
}
