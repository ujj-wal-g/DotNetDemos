using CrudWIthMySql.CommonLayer.Model;

namespace CrudWIthMySql.ServiceLayer
{
    public interface ICrudApplicationSL
    {
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
    }
}
