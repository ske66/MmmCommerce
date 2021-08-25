using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MmmCommerceAPI.MongoDb.Models
{
    public class UserModel
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Hash { get; set; }
        public DateTimeOffset LastLoginDate { get; set; }
        public long[] LastLoginCoords { get; set; }
        public RoleModel Role { get; set; }
    }
}
