using AspNetCoreAPI_Jwt_Bearer.DTOs;
using AspNetCoreAPI_Jwt_Bearer.Entities;

namespace AspNetCoreAPI_Jwt_Bearer.Interfaces
{
    public interface IEmployeeService
    {
        Task<List<EmployeeDto>> GetAll();
        Task<EmployeeDto> Get(int id);
    }
}
