using System;
using System.Collections.Generic;

namespace Core.Model
{
 public  class DimensionResult
 {
   public PartTemplate DimensionTemplate;
   public List<DimensionEntity> DimensionEntitys;

   public DateTime Time;

   public bool IsPassed
   {
     get
     {
       var isPassed = true;
       foreach (var dimensionEntity in DimensionEntitys)
       {
         if (dimensionEntity.Measured >= dimensionEntity.Nominal - dimensionEntity.MinusTol &&
             dimensionEntity.Measured <= dimensionEntity.Nominal + dimensionEntity.PlusTol)
           ;
         else
         {
           isPassed = false;
           break;
         };
       }
       return isPassed;
     }
   }


 }
}
