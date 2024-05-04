using System;

public class Client
{
    // Властивості класу
    public int Id { get; set; } // Унікальний ідентифікатор клієнта
    public string Name { get; set; } // Ім'я клієнта
    public string Email { get; set; } // Адреса електронної пошти клієнта
    public string PhoneNumber { get; set; } // Номер телефону клієнта

    // Конструктор класу
    public Client(int id, string name, string email, string phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
    }

    // Метод для відображення інформації про клієнта
    public void DisplayInfo()
    {
        Console.WriteLine($"ID: {Id}");
        Console.WriteLine($"Name: {Name}");
        Console.WriteLine($"Email: {Email}");
        Console.WriteLine($"Phone Number: {PhoneNumber}");
    }
}