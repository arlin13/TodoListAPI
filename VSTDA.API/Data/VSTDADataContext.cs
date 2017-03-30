using System.Data.Entity;
using VSTDA.API.Models;

namespace VSTDA.API.Data
{
    public class VSTDADataContext : DbContext
    {
        public IDbSet<TodoItem> TodoItems { get; set; }

        public VSTDADataContext()
            : base("VSTDA")
        {
        }
    }
}