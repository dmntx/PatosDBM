using System;
using System.Collections.Generic;
using System.Text;

namespace Patos
{
    class Turkey
    {

        private readonly IGraznar gluglu;
        private readonly IVolar fly;
        protected Turkey(IGraznar gluglu, IVolar fly)
        {
            this.gluglu = gluglu;
            this.fly = fly;
        }

    }
}
