using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Module
{
 public  class DimensionResult
 {
   public DimensionTemplate DimensionTemplate;
   public DimensionEntity DimensionEntity;
   public double Measured;

   public bool IsPassed
   {
     get
     {
       if (Measured >= DimensionEntity.Nominal - DimensionEntity.MinusTol

           && Measured <= DimensionEntity.Nominal + DimensionEntity.PlusTol)
         return true;
       else
         return false;
     }
   }
 }
}
