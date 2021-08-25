namespace MmmCommerceAPI.MongoDb.Models
{
    public class PermissionModel
    {
        public int PermissionId { get; set; }
        public string Permission { get; set; }
        public bool Allow { get; set; }
    }
}
