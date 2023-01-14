using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Engineer
  {
    public int EngineerId { get; set; }
    public string Name { get; set; }
    public string Specialty { get; set; }
    public int MachineId { get; set; }
    public Machine Machine { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}