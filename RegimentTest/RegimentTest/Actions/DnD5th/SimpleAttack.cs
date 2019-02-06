using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegimentTest.Classes;

namespace RegimentTest.Actions.DnD5th
{
  public class SimpleAttack : IAction
  {
    public int AttackBonus { get; set; }
    public int DiceSides { get; set; }
    public int DamageBonus { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public void ExecuteAction(TargetObject target)
    {
      Random ran = new Random();
      int diceRoll = ran.Next(20) + 1;
      if(diceRoll == 20) // crit
      {
        target.TargetCharacter.HitpointsCurrent -= ran.Next(DiceSides) + 1 + ran.Next(DiceSides) + 1 + DamageBonus;
      }
      else 
      if (ran.Next(20) +1 + AttackBonus >= target.TargetCharacter.ArmorClass)
      {
        target.TargetCharacter.HitpointsCurrent -= ran.Next(DiceSides) + 1 + DamageBonus;
      }
    }
  }
}
