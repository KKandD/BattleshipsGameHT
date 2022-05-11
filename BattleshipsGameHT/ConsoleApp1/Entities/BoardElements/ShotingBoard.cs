using ConsoleApp1.Enums;
using ConsoleApp1.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Entities.BoardElements
{
    public class ShotingBoard : GameBoard
    {
        public List<Coordinates> GetOpenRandomPanels()
        {
            return Panels.Where(x => x.OccupationType == OccupationTypeEnum.Empty && x.IsRandomAvailable).Select(x => x.Coordinates).ToList();
        }

        public List<Coordinates> GetHitNeighbors()
        {
            List<Panel> panels = new List<Panel>();
            var hits = Panels.Where(x => x.OccupationType == OccupationTypeEnum.Hit);
            foreach (var hit in hits)
            {
                panels.AddRange(GetNeighbors(hit.Coordinates).ToList());
            }
            return panels.Distinct().Where(x => x.OccupationType == OccupationTypeEnum.Empty).Select(x => x.Coordinates).ToList();
        }

        public List<Panel> GetNeighbors(Coordinates coordinates)
        {
            int row = coordinates.Row;
            int column = coordinates.Column;
            List<Panel> panels = new List<Panel>();
            if (column > 1)
            {
                panels.Add(Panels.At(row, column - 1));
            }
            if (row > 1)
            {
                panels.Add(Panels.At(row - 1, column));
            }
            if (row < 10)
            {
                panels.Add(Panels.At(row + 1, column));
            }
            if (column < 10)
            {
                panels.Add(Panels.At(row, column + 1));
            }
            return panels;
        }
    }
}
