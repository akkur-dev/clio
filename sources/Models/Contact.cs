using Clio.Helpers;

namespace Clio.Models;

/// <summary>
/// Контакт
/// </summary>
public class Contact : ObservableObject
{
    private string _firstName;

    private string _lastName;

    private string _middleName;

    private string _phone;

    private string _email;

    private DateOnly? _birthDate;

    /// <summary>
    /// Имя
    /// </summary>
    public string FirstName 
    {
        get => _firstName; 
        set
        {
            if (SetProperty(ref _firstName, value))
            {
                OnPropertyChanged(nameof(FullName));
            }
        }
    }

    /// <summary>
    /// Фамилия
    /// </summary>
    public string LastName 
    {
        get => _lastName;
        set
        {
            if (SetProperty(ref _lastName, value))
            {
                OnPropertyChanged(nameof(FullName));
            }
        }
    }

    /// <summary>
    /// Отчество
    /// </summary>
    public string MiddleName
    {
        get => _middleName;
        set => SetProperty(ref _middleName, value);
    }

    /// <summary>
    /// Номер телефона
    /// </summary>
    public string Phone 
    {
        get => _phone; 
        set => SetProperty(ref _phone, value);
    }

    /// <summary>
    /// Электронная почта
    /// </summary>
    public string Email 
    {
        get => _email; 
        set => SetProperty(ref _email, value); 
    }

    /// <summary>
    /// Дата рождения
    /// </summary>
    public DateOnly? BirthDate
    {
        get => _birthDate;
        set => SetProperty(ref _birthDate, value);
    }

    /// <summary>
    /// Полное имя (фамилия + имя)
    /// </summary>
    public string FullName => $"{FirstName} {LastName}".Trim();
}
