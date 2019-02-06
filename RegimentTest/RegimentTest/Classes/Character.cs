using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegimentTest.Actions;

namespace RegimentTest.Classes
{
  public enum CharacterType
  {
    Soldier, Archer, Unique
  }
  public class Character
  {
    public int ArmorClass { get; set; }
    public int Speed { get; set; }
    public int Initiative { get; set; }
    public int HitpointsMaximum { get; set; }
    public int HitpointsCurrent { get; set; }
    public List<IAction> Actions { get; set; } // create action 
    public Character(CharacterType type)
    {
      switch (type)
      {
        case CharacterType.Soldier:
          // create a soldier class
          ArmorClass = 16;
          Speed = 30;
          Initiative = 1;
          HitpointsMaximum = 16;
          HitpointsCurrent = HitpointsMaximum;
          Actions = new List<IAction>()
          { new SimpleAttack() { DiceSides = 6, AttackBonus = 4, DamageBonus = 2 } };
          break;
        case CharacterType.Archer:
          // create an archer class
          break;
        case CharacterType.Unique:
          throw new Exception("Cannot create an unique character without specific data");
        default:
          break;
      }
    }
  }
}
