using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlazorShared.Models.Enum;

namespace BlazorShared.Models;
public class OrderDetail
{
    public int OrderId { get; set; }
    public string ProductName { get; set; }
    public int Units { get; set; }
    public decimal UnitPrice { get; set; }
}
