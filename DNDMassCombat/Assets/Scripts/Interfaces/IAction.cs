
using Classes;

namespace interfaces
{
  public interface IAction
  {
    string Name { get; set; }
    string Description { get; set; }
    void ExecuteAction(TargetObject target);
  }
}
