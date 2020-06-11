namespace WimmServerless.Core.Entities
{
    public class Account
    {
        public int Id { get; set; }
        public User OwnerUser { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
    }
}
