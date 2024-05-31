using PersonelApp.WebAPI.Context;
using PersonelApp.WebAPI.Models;

namespace PersonelApp.WebAPI.Repositories;

public sealed class PersonelRepository(ApplicationDbContext context):IPersonelRepository
{
    public IQueryable<Personel> GetAll()
    {
        var personels = context.Personels.AsQueryable();
        return personels;
    }

    public bool Create(Personel personel)
    {
        context.Add(personel);
        var result = context.SaveChanges();
        return (result > 0);
    }

    public bool IsPersonelExists(string FirstName, string LastName)
    {
        bool result = context.Personels.Any(p => p.FirstName == FirstName && p.LastName == LastName);
        return result;
    }
}
