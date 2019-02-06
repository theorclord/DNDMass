using RegimentTest.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimentTest.Actions
{
  public class SimpleSpell : IAction
  {
    public string Name { get; set; }
    public string Description { get; set; }

    public void ExecuteAction(TargetObject target)
    {
      Random ran = new Random();
      int damageRolls = ran.Next(4) + ran.Next(4) + ran.Next(4) + 3;
      target.TargetCharacter.HitpointsCurrent -= damageRolls + 3;
    }
  }
}
