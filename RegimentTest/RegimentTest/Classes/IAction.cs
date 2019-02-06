﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegimentTest.Classes
{
  public interface IAction
  {
    string Name { get; set; }
    string Description { get; set; }
    void ExecuteAction(TargetObject target);
  }
}
