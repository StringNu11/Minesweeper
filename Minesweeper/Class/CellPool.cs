﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Class
{
  public static class CellPool
  {
    private static List<Cell> cellPool = new List<Cell>();
    public static Cell GetCell(int index)
    {
      if (cellPool.Count != 0)
        return cellPool.Last();
      else
        return new Cell(index);
    }

    //public static List<Cell> GetCell(int amount)
    //{
    //  if (amount >= cellPool.Count)
    //  {
    //    int owe = amount - cellPool.Count;
    //    var result = cellPool.ToList();
    //    for (int i = 0; i < owe; i++)
    //    {
    //      result.Add(new Cell());
    //    }
    //  }
    //  return cellPool.Take(amount).ToList();
    //}

    public static void ReturnCell(Cell cell)
    {
      if (!cellPool.Contains(cell))
        cellPool.Add(cell);
    }
  }
}
