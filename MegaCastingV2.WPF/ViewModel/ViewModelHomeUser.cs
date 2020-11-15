using MegaCastingV2.DBlib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaCastingV2.WPF.ViewModel
{
    class ViewModelHomeUser
    {
        private MegaCastingEntities entities;

        public ViewModelHomeUser(MegaCastingEntities entities)
        {
            this.entities = entities;
        }
    }
}
