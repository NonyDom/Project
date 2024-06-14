namespace Bookme.ViewModels
{
    public class ApplicationUserViewModel
    {
    
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? GenderId { get; set; }
        public string PhoneNumber { get; set; }
        public string? Address { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
        public string UserName { get; set; }
        public string MusicSpecialization { set; get; }
        public string Bio { get; set; }
        public DateTime DateCreated { get; set; }
        public int CategoryId { get; set; }
        public bool IsDeactivated { get; set; }

    }
}
