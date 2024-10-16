using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NorthWind.Entities.ValueObjets;

public class UserAction(string user, string description)
{
    public DateTime CreatedDateTime { get; } = DateTime.Now;
    public string user => user;
    public string Description => description;
}
