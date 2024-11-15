public class ProductionOrder
{
    public int ProductionOrderId { get; set; }
    public int ProductId { get; set; }
    public Product Product { get; set; }
    public DateTime ScheduledDate { get; set; }
    public int Quantity { get; set; }
    public List<WorkstationCapacity> WorkstationCapacities { get; set; }
}