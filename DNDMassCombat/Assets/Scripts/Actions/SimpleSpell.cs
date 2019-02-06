
using Classes;
using interfaces;
using System;

namespace Actions
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
