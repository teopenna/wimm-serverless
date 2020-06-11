using System.Collections.Generic;

namespace WimmServerless.Core.Entities
{
    public class LinkedUsers
    {
        public User MainUser { get; set; }
        public IList<User> ChildrenUsers { get; set; }
    }
}
