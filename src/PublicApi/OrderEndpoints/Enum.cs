namespace Microsoft.eShopWeb.PublicApi.OrderEndpoints;

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
