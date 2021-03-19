using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Visitor.Elements;
using SWP_Visitor.Visitors;

namespace SWP_Visitor
{
    public class VisitorClient
    {
        public static void ElementsAcceptVisitor(List<IElement> elements, IVisitor visitor)
        {
            elements.ForEach(element => element.Accept(visitor));
        }
    }
}
