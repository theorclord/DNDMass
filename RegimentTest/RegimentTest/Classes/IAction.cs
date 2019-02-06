using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimentTest.Classes
{
  public interface IAction
  {
    void ExecuteAction(TargetObject target);
  }
}
