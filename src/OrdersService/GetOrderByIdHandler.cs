namespace OrdersService;

public sealed class GetOrderByIdHandler
{
    public Task<GetOrderByIdResponse> Handle(GetOrderById request, CancellationToken ct)
    {
        ct.ThrowIfCancellationRequested();
        return Task.FromResult(new GetOrderByIdResponse(request.OrderId, "created"));
    }
}
