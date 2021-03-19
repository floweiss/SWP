using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Visitor.Elements;

namespace SWP_Visitor.Visitors
{
    public interface IVisitor
    {
        public void Visit(Ramp ramp);
        public void Visit(Target target);
        public void Visit(Led led);
    }
}
