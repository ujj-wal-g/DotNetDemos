using CrudWIthMySql.CommonLayer.Model;

namespace CrudWIthMySql.ServiceLayer
{
    public interface ICrudApplicationSL
    {
        public Task<AddInformationResponse> AddInformation(AddInformationRequest request);
        public Task<ReadAllInformationResponse> ReadAllInformation();
        public Task<UpdateAllInformationResponse> UpdateInformation(UpdateAllInformationRequest request);
        public Task<DeleteInformationResponse> DeleteInformation(DeleteInformationRequest request);
        public Task<GetAllDeleteInformationResponse> GetAllDeleteInformation();
    }
}
