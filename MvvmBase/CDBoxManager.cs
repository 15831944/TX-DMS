using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MvvmBase
{
  public class CDBoxManager
  {
    public static List<BoxEntity> LoadBoxEntities()
    {
      var cdBoxItems = new List<BoxEntity>();
      try
      {
        var sr = new StreamReader("LightBoxChecking.data");
        do
        {
          string aLine = sr.ReadLine();
          if (aLine == null)
            break;
          var aEntity = aLine.Split(';');
          cdBoxItems.Add(new BoxEntity()
          {
            Index = (cdBoxItems.Count + 1).ToString("G"),
            NominalEV = aEntity[0],
            NominalX = aEntity[1],
            NominalY = aEntity[2],
            MeasuredEV = aEntity[3],
            MeasuredX = aEntity[4],
            MeasuredY = aEntity[5]
          });
        } while (true);
      }
      catch
      {

      }
      return cdBoxItems;
    }

    /// <summary>
    /// y = bx + a; refer to http://equinox1993.blog.163.com/blog/static/32205137201091611386204/
    /// </summary>
    /// <param name="i_BoxEntities"></param>
    /// <param name="i_A"></param>
    /// <param name="b"></param>
    /// <param name="k"></param>
    public static void RtCalculateLine(List<BoxEntity> i_BoxEntities, ref float a, ref float b)
    {
      int num = i_BoxEntities.Count;
      if (num < 2) return;
      int i = 0;

      float tx = 0, ty = 0, sigma_xy = 0, sigma_xx = 0, sum_x = 0, sum_y = 0;
      while (i < num)
      {
        tx = float.Parse((i_BoxEntities[i]).MeasuredEV);
        ty = float.Parse((i_BoxEntities[i]).NominalEV);
        sigma_xy += tx * ty;
        sigma_xx += tx * tx;
        sum_x += tx;
        sum_y += ty;
        i++;
      }

      float x_bar = sum_x / num;
      float y_bar = sum_y / num;
      float nxy_bar = num * x_bar * y_bar;
      float nxx = num * x_bar * x_bar;

      b = (sigma_xy - nxy_bar) / (sigma_xx - nxx);
      a = y_bar - b * x_bar;
    }
  }
}
