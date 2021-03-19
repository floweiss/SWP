using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SWP_Visitor.Visitors;

namespace SWP_Visitor.Elements
{
    public interface IElement
    {
        public void Accept(IVisitor visitor);
        public void Reset();
        public int GetPoints();
        public string GetReport();
    }
}
