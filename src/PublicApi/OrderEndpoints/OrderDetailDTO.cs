using static BlazorShared.Models.Enum;

namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

public class OrderDetailDTO

{
    public int OrderId { get; set; }
    public string? ProductName { get; set; }
    public int Units { get; set; }
    public decimal UnitPrice { get; set; }
    public OrderStatus OrderStatus { get; set; }


}
