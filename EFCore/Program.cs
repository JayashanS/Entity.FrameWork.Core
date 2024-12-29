using EFCore.Data;
using Microsoft.EntityFrameworkCore;

using (var context = new AppDbContext())
{
    //var manager = new Manager();
    //manager.MngFirstName = "Ravi";
    //manager.MngLastName = " G";

    //context.Managers.Add(manager);
    //context.SaveChanges();

    //var managers = context.managers.tolist();
    //foreach (var manager in managers)
    //{
    //    console.writeline($"name:{manager.mngfirstname}");
    //}

    var projects = context.Projects.Include(p => p.Name).ToList();



}
