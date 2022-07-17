using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.BusinessLogic.Interfaces;

public interface IRecordService
{
    Task<List<Record?>> GetAll();
    
    Task<Record?> Get(int id);
    
    void Create(Record record);
    
    void Edit(Record record);

    void Delete(int id);
}