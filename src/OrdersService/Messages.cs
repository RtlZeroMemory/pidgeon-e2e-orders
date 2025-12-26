using SDG.Pidgeon.Abstractions;

namespace OrdersService;

[MessageName("query.orders.getbyid")]
public sealed record GetOrderById(string OrderId);

[MessageName("query.orders.getbyid.response")]
public sealed record GetOrderByIdResponse(string OrderId, string Status);

[MessageName("event.orders.created.v1")]
public sealed record OrderCreated(string OrderId);
