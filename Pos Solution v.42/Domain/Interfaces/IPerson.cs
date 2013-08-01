using System;
namespace Domain
{
    public interface IPerson
    {
        string FirstName { get; }
        Guid Id { get; }
        string LastName { get; }
        string ContactNumber { get; }
        string Email { get; }
    }
}
