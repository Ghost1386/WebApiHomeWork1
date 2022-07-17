using Microsoft.EntityFrameworkCore;
using WebApiHomeWork1.BusinessLogic.Context;
using WebApiHomeWork1.BusinessLogic.Interfaces;
using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.BusinessLogic.Services;

public class RecordService : IRecordService
{
    private readonly RecordContext _db;

    public RecordService(RecordContext db)
    {
        _db = db;
    }
    
    public async Task<List<Record?>> GetAll()
    {
        return await _db.Records.ToListAsync();
    }

    public async Task<Record?> Get(int id)
    {
        Record? record = await _db.Records.FirstOrDefaultAsync(
            x => x != null && x.Id == id);
        
        return record;
    }

    public async void Create(Record record)
    {
        _db.Records.Add(record);
        await _db.SaveChangesAsync();
    }

    public async void Edit(Record record)
    {
        if (!_db.Records.Any(x => x != null && x.Id ==record.Id))
        {
            return;
        }
 
        _db.Update(record);
        await _db.SaveChangesAsync();
    }

    public async void Delete(int id)
    {
        Record? record = _db.Records.FirstOrDefault(x => x != null && x.Id == id);
        
        _db.Records.Remove(record);
        await _db.SaveChangesAsync();
    }
}