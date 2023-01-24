using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    internal class Adapter : ITarget
    {
        private readonly Adaptation _adaptt;

        public Adapter(Adaptation adaptt)
        {
            _adaptt = adaptt;
        }

        public string GetRequest()
        {
            return $"To jest: {_adaptt.GetSpecificRequest()}";
        }
    }
}
