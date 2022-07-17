using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiHomeWork1.BusinessLogic.Services;
using WebApiHomeWork1.Common.Models;

namespace WebApiHomeWork1.Controllers;

[ApiController]
[Route("api/[record-controller]")]
public class RecordController : ControllerBase
{
    private readonly RecordService _recordService;

    public RecordController(RecordService recordService)
    {
        _recordService = recordService;
    }
    
    [HttpGet]
    public Task<List<Record?>> GetAllRecord()
    {
        return _recordService.GetAll();
    }
    
    [HttpGet("{id}")]
    public Task<Record?> GetUser(int id)
    {
        return _recordService.Get(id);
    }
    
    [HttpPost]
    public void CreateNewUser(Record record)
    {
        if (ModelState.IsValid)
        {
            _recordService.Create(record);
        }
    }
    
    [HttpPut]
    public void EditUser(Record record)
    {
        if (ModelState.IsValid)
        {
            _recordService.Edit(record);
        }
    }
    
    [HttpDelete("{id}")]
    public void DeleteRecord(int id)
    {
        _recordService.Delete(id);
    }
}