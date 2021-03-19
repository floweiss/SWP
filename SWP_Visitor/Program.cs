using System;
using System.Collections.Generic;
using SWP_Visitor.Elements;
using SWP_Visitor.Visitors;

namespace SWP_Visitor
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IElement> elements = new List<IElement>();
            elements.Add(new Ramp("Airramp", true, 20, 3, true));
            elements.Add(new Led(69, true, Color.Red, 10));
            elements.Add(new Target('Y', false, 15));

            Console.WriteLine("Report state at the beginning:");
            IVisitor visitor = new ReportVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, visitor);

            Console.WriteLine("\nGet points:");
            visitor = new PointVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, visitor);

            Console.WriteLine("\nReset elements");
            visitor = new ResetVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, visitor);

            Console.WriteLine("\nReport state at the end:");
            visitor = new ReportVisitor();
            VisitorClient.ElementsAcceptVisitor(elements, visitor);
        }
    }
}
