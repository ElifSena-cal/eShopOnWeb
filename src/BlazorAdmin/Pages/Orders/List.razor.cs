using System.Collections.Generic;
using System.Threading.Tasks;
using BlazorAdmin.Helpers;
using BlazorShared.Interfaces;
using BlazorShared.Models;
using static BlazorShared.Models.Enum;


namespace BlazorAdmin.Pages.Orders;

public partial class List : BlazorComponent
{
    [Microsoft.AspNetCore.Components.Inject]
    public IOrderService OrdersService { get; set; }

    private List<Order> _orders = new List<Order>();
    private Details Details { get; set; }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            _orders = await OrdersService.List();
            CallRequestRefresh();
        }

        await base.OnAfterRenderAsync(firstRender);
    }
    private async void DetailsClick(int id)
    {
        await Details.Open(id);
    }
    private async void ReloadOrders()
    {
        _orders = await OrdersService.List();
        StateHasChanged();
    }
    public static OrderStatus ConvertToOrderStatus(OrderStatus value)
    {
        return value;
    }
}
