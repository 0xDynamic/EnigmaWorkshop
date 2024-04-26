using enigmaworkshop.backend.Models;

public class CustomerDTO
{

    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public DateOnly DoB { get; set; }
    public string Phone { get; set; } = null!;
    public string? Email { get; set; }
    public AddressDTO? Address { get; set; } = null!;

}