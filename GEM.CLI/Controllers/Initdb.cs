/*using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Linq;
namespace GEMAPI.models;

[ApiController]
[Route("[controller]")]
public class InitDatabaseController : ControllerBase
{
    private readonly GemContext _context;

    public InitDatabaseController(GemContext context)
    {
        _context = context;
    }

    [HttpPost]
    public IActionResult InitializeDatabase()
    {
        var tables = _context.Model.GetEntityTypes();
        int insertedCount = 0;

        foreach (var table in tables)
        {
            var entityType = table.ClrType;
            var instance = Activator.CreateInstance(entityType);

            var idProperty = entityType.GetProperty("Id");
            if (idProperty != null)
            {
                _context.Add(instance);
                insertedCount++;
            }
        }

        _context.SaveChanges();

        // Logging with Debug
        Debug.WriteLine($"Inserted {insertedCount} records into database.");

        return Ok(new { Message = "Records inserted into all tables.", Inserted = insertedCount });
    }
}*/
