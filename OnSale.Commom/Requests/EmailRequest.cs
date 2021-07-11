using System.ComponentModel.DataAnnotations;


namespace OnSale.Commom.Requests
{
    public class EmailRequest
    {
        [EmailAddress]
        [Required]
        public string Email { get; set; }
    }
}
