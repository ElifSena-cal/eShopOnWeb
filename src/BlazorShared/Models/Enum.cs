using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Models;
public class Enum
{
    public enum OrderStatus
    {
        Pending = 1,
        Approved,
        Shipped,
        Delivered,
        Cancelled
    }
}
