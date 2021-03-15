using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWP_Command_Composite
{
    public class PointReceiver
    {
        private int _points;

        public PointReceiver(int initialPoints)
        {
            _points = initialPoints;
        }

        public void AddPoints(int points)
        {
            _points += points;
        }
        public int GetPoints()
        {
            return _points;
        }
    }
}
