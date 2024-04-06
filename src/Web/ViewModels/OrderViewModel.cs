using Microsoft.eShopWeb.ApplicationCore.Entities.OrderAggregate;

namespace Microsoft.eShopWeb.Web.ViewModels;


public class OrderViewModel
{
    public int OrderNumber { get; set; }
    public string? UserName { get; set; }
    public DateTimeOffset OrderDate { get; set; }
    public decimal Total { get; set; }
    public OrderStatus Status { get; set; } = OrderStatus.Pending;
    public Address? ShippingAddress { get; set; }
}
public enum OrderStatus
{
    Pending = 1,
    Approved,
    Shipped,
    Delivered,
    Cancelled
}
