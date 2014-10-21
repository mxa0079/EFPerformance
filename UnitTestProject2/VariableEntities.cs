using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class VariableEntities
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public IList<TextOption> TextOptions
        {
            get;
            set;
        }
    }

    public class TextOption
    {
        public int Id { get; set; }
        public string Text { get; set; }

        public int VariableEntitiesId { get; set; }
    }
}
