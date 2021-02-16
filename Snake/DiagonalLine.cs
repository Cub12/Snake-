using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class DiagonalLine : Figure
    {
        public DiagonalLine(int yUp, int yDown, int xLeft, int xRight, char sym)
		{
			pList = new List<Point>();
			for (int y = yUp; y <= yDown; y++)
			{
				for (int x = xLeft; x <= xRight; x++) {
				Point p = new Point(x, y, sym);
				pList.Add(p); }
			}
		}
	}
}
