public class SizeGuide
{
    public string GetChestSize(Enum sizeEnum)
    {
        if(sizeEnum is not ClothingSize)
            return "Invalid size!";
        if(sizeEnum is ClothingSize.S)
            return "S = 88-92cm";
        if(sizeEnum is ClothingSize.M)
            return "M = 96-100cm";
        if(sizeEnum is ClothingSize.L)
            return "L = 101-110cm";
        if(sizeEnum is ClothingSize.XL)
            return "XL = 110-116cm";
        return "Invalid size!";
    }
}