
using Assets.Scripts.Classes;

namespace Assets.Scripts.Interfaces
{
  public interface IAction
  {
    string Name { get; set; }
    string Description { get; set; }
    void ExecuteAction(TargetObject target);
  }
}
