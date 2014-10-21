using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class Variable
    {
        public string Name { get; set; }

        public int Id { get; set; }

        public virtual IList<string> TextOptions
        {
            get
            {

                return _TextOptions;

            }
            set
            {
                _TextOptions = value;
            }
        }

        private IList<string> _TextOptions;

        public string TextOptionsSerialized
        {
            get
            {
                return String.Join(";", _TextOptions);
            }
            set
            {
                _TextOptions = value.Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            }
        }
    }
}
