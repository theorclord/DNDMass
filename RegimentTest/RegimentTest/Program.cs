using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RegimentTest.Classes;

namespace RegimentTest
{
  class Program
  {
    static void Main(string[] args)
    {
      Character cha1 = new Character(CharacterType.Soldier);
      Character cha2 = new Character(CharacterType.Soldier);
      cha1.Actions[0].ExecuteAction(new TargetObject() { TargetCharacter = cha2 });
    }
  }
}
