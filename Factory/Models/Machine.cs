using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Factory.Models
{
  public class Machine
  {
    public int MachineId { get; set; }
    [Required(ErrorMessage = "Please Enter a Name.")]
    public string Name { get; set; }
    public string Type { get; set; }
    public List<EngineerMachine> JoinEntities { get; }
  }
}