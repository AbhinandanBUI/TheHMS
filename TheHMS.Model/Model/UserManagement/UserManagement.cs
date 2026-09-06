namespace TheHMS.Model.Model.UserManagement
{
    public class UserManagementDTO
    {
        public long UserID { get; set; }
        public string UserName { get; set; } = string.Empty;
        public required string FirstName { get; set; }  
        public required string LastName { get; set; }  
        public required string Phone { get; set; }  
        public required string Email { get; set; }  
        public required string Password { get; set; }   
        public required string HashPassword { get; set; }
        public long? AddressId { get; set; } = null;
        public bool IsActive { get; set; } = true;
         public long RoleId { get; set; } = 0;
        public DateTime RegistrationDate { get; set; } = DateTime.Now; 
    }
}
