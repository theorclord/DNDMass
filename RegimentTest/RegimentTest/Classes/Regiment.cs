using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimentTest.Classes
{
  public class Regiment
  {
    public List<Character> Characters { get; set; }

    public Regiment() { }

    public void AttackRegiment(IAction action, CharacterType type, Regiment regiment)
    {

    }
  }
}
