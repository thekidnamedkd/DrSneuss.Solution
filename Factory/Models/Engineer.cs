using System.Collections.Generic;

namespace Factory.Models
{
  public class Engineer
  {
    public Engineer ()
    {
      this.Machines = new HashSet<MachineEngineer>();
    }
    public int EngineerId { get; set; }
    public string EngineerName { get; set; }
    public System.DateTime HireDate { get; set; }
    public ICollection<MachineEngineer> Machines{ get; set; }

  }
}