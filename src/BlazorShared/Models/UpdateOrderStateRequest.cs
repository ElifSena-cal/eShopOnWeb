using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BlazorShared.Models.Enum;

namespace BlazorShared.Models;
public class UpdateOrderStateRequest
{
    public int OrderId { get; set; }
    public OrderStatus OrderStatus { get; set; }
}
