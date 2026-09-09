static void GetItemInfo<T>(T item) where T : IEntity
    {
        Console.WriteLine($"ID: {item.Id}");
    }
        User user = new User
        {
            Id = 101
        };

        Product product = new Product
        {
            Id = 202
        };

GetItemInfo(user);
GetItemInfo(product);
    