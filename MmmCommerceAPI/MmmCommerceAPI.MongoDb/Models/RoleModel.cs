using System.Collections.Generic;

namespace MmmCommerceAPI.MongoDb.Models
{
    public class RoleModel
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public List<PermissionModel> Permissions {get; set;}
    }
}
