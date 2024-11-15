public class WorkstationCapacity
{
    public int WorkstationCapacityId { get; set; }
    public int ProductionOrderId { get; set; }
    public ProductionOrder ProductionOrder { get; set; }
    public int WorkstationId { get; set; }
    public Workstation Workstation { get; set; }
    public int UsedCapacityMinutes { get; set; }
}