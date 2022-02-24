using CrudWIthMySql.CommonLayer.Model;

namespace CrudWIthMySql.RepositoryLayer
{
    public interface ICrudApplicationRL
    {
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
    }
}
