using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
	class Walls
	{
		List<Figure> wallList;

		public Walls(int mapWidth, int mapHeight)
		{
			wallList = new List<Figure>();

			// Отрисовка рамочки
			HorizontalLine upLine = new HorizontalLine(0, mapWidth - 2, 0, '+');
			HorizontalLine downLine = new HorizontalLine(0, mapWidth - 2, mapHeight - 1, '+');
			VerticalLine leftLine = new VerticalLine(0, mapHeight - 1, 0, '+');
			VerticalLine rightLine = new VerticalLine(0, mapHeight - 1, mapWidth - 2, '+');
			
			// S
			HorizontalLine upLine1 = new HorizontalLine(2, 22, 2, '#');
			VerticalLine leftLine1 = new VerticalLine(2, 12, 2, '#');
			HorizontalLine upLine2 = new HorizontalLine(2, 22, 12, '#');
			VerticalLine rightLine1 = new VerticalLine(12, 22, 22, '#');
			HorizontalLine downLine1 = new HorizontalLine(2, 22, 22, '#');
			
			// E
			HorizontalLine upLine3 = new HorizontalLine(27, 47, 2, '@');
			VerticalLine leftLine3 = new VerticalLine(2, 22, 27, '@');
			HorizontalLine upLine4 = new HorizontalLine(27, 47, 12, '@');
			HorizontalLine downLine2 = new HorizontalLine(27, 47, 22, '@');

			// R
			HorizontalLine upLine5 = new HorizontalLine(52, 72, 2, '&');
			VerticalLine leftLine4 = new VerticalLine(2, 22, 52, '&');
			VerticalLine rightLine2 = new VerticalLine(2, 9, 72, '&');
			HorizontalLine downLine3 = new HorizontalLine(52, 72, 12, '&');
			VerticalLine rightLine6 = new VerticalLine(12, 22, 65, '&');
			HorizontalLine downLine6 = new HorizontalLine(65, 72, 22, '%');

			// Y
			VerticalLine leftLine6 = new VerticalLine(2, 12, 77, '~');
			VerticalLine leftLine7 = new VerticalLine(2, 12, 97, '~');
			HorizontalLine downLine7 = new HorizontalLine(77, 97, 12, '~');
			VerticalLine leftLine8 = new VerticalLine(12, 22, 87, '~');

			// O
			HorizontalLine upLine7 = new HorizontalLine(102, 122, 2, ':');
			HorizontalLine upLine8 = new HorizontalLine(102, 122, 22, ':');
			VerticalLine rightLine7 = new VerticalLine(5, 22, 102, ':');
			VerticalLine rightLine8 = new VerticalLine(2, 22, 122, ':');

			// G
			HorizontalLine upLine6 = new HorizontalLine(127, 147, 2, '%');
			VerticalLine leftLine5 = new VerticalLine(2, 22, 127, '%');
			HorizontalLine downLine4 = new HorizontalLine(137, 147, 12, '%');
			VerticalLine rightLine3 = new VerticalLine(12, 22, 147, '%');
			HorizontalLine downLine5 = new HorizontalLine(127, 147, 22, '%');
			VerticalLine rightLine4 = new VerticalLine(12, 17, 137, '%');

			// A
			HorizontalLine downLine8 = new HorizontalLine(152, 177, 2, '?');
			HorizontalLine downLine9 = new HorizontalLine(152, 177, 12, '?');
			VerticalLine leftLine9 = new VerticalLine(5, 22, 152, '?');
			VerticalLine leftLine10 = new VerticalLine(2, 22, 177, '?');

			wallList.Add(upLine);
			wallList.Add(downLine);
			wallList.Add(leftLine);
			wallList.Add(rightLine);

			// s
			wallList.Add(upLine1);
			wallList.Add(leftLine1);
			wallList.Add(upLine2);
			wallList.Add(rightLine1);
			wallList.Add(downLine1);
            
			// e
			wallList.Add(upLine3);
			wallList.Add(leftLine3);
			wallList.Add(upLine4);
			wallList.Add(downLine2);

			// r
			wallList.Add(upLine5);
			wallList.Add(leftLine4);
			wallList.Add(rightLine2);
			wallList.Add(downLine3);
			wallList.Add(rightLine6);
			wallList.Add(downLine6);

			// y
			wallList.Add(leftLine6);
			wallList.Add(leftLine7);
			wallList.Add(downLine7);
			wallList.Add(leftLine8);

			// o
			wallList.Add(upLine7);
			wallList.Add(upLine8);
			wallList.Add(rightLine7);
			wallList.Add(rightLine8);

			// g
			wallList.Add(upLine6);
			wallList.Add(leftLine5);
			wallList.Add(downLine4);
			wallList.Add(rightLine3);
			wallList.Add(downLine5);
			wallList.Add(rightLine4);

			// a
			wallList.Add(downLine8);
			wallList.Add(downLine9);
			wallList.Add(leftLine9);
			wallList.Add(leftLine10);
		}

		internal bool IsHit(Figure figure)
		{
			foreach (var wall in wallList)
			{
				if (wall.IsHit(figure))
				{
					return true;
				}
			}
			return false;
		}

		public void Draw()
		{
			foreach (var wall in wallList)
			{
				wall.Draw();
			}
		}
	}
}
