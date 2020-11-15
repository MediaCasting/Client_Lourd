using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.DBlib
{
    public partial class ContractType
    {
        public string FullName => this.Identifier.ToString() + " - " + this.Name;
        public override string ToString()
        {
            return this.Name.ToString();
        }
    }
}
