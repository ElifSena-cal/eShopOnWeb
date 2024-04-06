using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorShared.Models;
public class OrderDetailResponse
{
    public List<OrderDetail> OrderDetails { get; set; } = new List<OrderDetail>();
}
