using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using BlazorShared.Interfaces;

namespace BlazorShared.Models;
public class OrderResponse 
{
    public List<Order> Orders { get; set; } = new List<Order>();
}
