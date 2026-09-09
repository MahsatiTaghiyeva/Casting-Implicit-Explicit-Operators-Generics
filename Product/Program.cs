bool CanBeCancelled(Enum statusEnum)
{
    if(statusEnum is not OrderStatus)
    {
        return false;
    }
    if(statusEnum is OrderStatus.Pending || statusEnum is OrderStatus.Processing)
    {
        return true;
    }
    return false;
}
Console.WriteLine(CanBeCancelled(OrderStatus.Delivered));
Console.WriteLine(CanBeCancelled(OrderStatus.Cancelled));
Console.WriteLine(CanBeCancelled(OrderStatus.Pending));
Console.WriteLine(CanBeCancelled(OrderStatus.Shipped));