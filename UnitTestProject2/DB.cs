using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class DB : DbContext
    {
        public DbSet<Variable> Variables_String_Serializer { get; set; }

        public DbSet<VariableEntities> Variables_Entity { get; set; }
        public DbSet<TextOption> TextOptions { get; set; }

        public DbSet<VariableJson> Variable_Json_Serializer { get; set; }
    }
}
