public class BOMEntry
{
    public int BOMEntryId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public int ComponentId { get; set; }
    public Component Component { get; set; }
    public int Quantity { get; set; }
}
