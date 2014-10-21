using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTestProject2
{
    public class VariableJson
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
                return JsonConvert.SerializeObject(_TextOptions);
            }
            set
            {
                _TextOptions = JsonConvert.DeserializeObject<IList<string>>(value);                    
            }
        }
    }
}
