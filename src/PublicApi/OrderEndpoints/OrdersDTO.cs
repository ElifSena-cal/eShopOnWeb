using System;
using static BlazorShared.Models.Enum;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;


public class OrdersDTO
{
    public int Id { get; set; }
    public string BuyerId { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public OrderStatus OrderStatus { get; set; }
    public decimal TotalPrice { get; set; }
}
