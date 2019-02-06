using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegimentTest.Classes;

namespace RegimentTest.Actions
{
  public class SimpleAttack : IAction
  {
    public int AttackBonus { get; set; }
    public int DiceSides { get; set; }
    public int DamageBonus { get; set; }
    public void ExecuteAction(TargetObject target)
    {
      Random ran = new Random();
      if(ran.Next(20) +1 + AttackBonus >= target.TargetCharacter.ArmorClass)
      {
        target.TargetCharacter.HitpointsCurrent -= ran.Next(DiceSides) + 1 + DamageBonus;
      }
    }
  }
}
