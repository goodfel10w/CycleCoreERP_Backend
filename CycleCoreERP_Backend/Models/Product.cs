public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } // z.B. "Kinderfahrrad", "Damenfahrrad"
    public List<BOMEntry> BillOfMaterials { get; set; } // Liste der Stücklisteinträge
}