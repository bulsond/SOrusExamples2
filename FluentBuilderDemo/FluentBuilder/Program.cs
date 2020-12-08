using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/**
 * Незавершенный вариант из вопроса https://ru.stackoverflow.com/q/1215963/222542
 */

namespace FluentBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("FluentBuilder");
            Console.WriteLine(new string('_', 70));

            Person person = new PersonBuilder()
                               .Set(p => p.FirstName, "Андрей")
                               .Set(p => p.LastName, "Иванов")
                               .Build();

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }

    class PersonBuilder
    {
        //аккумулятор названий свойств и их значений
        private readonly Dictionary<string, object> _propertiesToBuild;

        public PersonBuilder()
        {
            _propertiesToBuild = new Dictionary<string, object>();
        }

        //запоминание в словаре названия свойства и его значения
        public PersonBuilder Set<T>(Expression<Func<Person, T>> expression, T value)
        {
            var propertyName = ((MemberExpression)expression.Body).Member.Name;
            _propertiesToBuild.Add(propertyName, value);
            return this;
        }

        public T Include<T>(Expression<Func<Person, T>> expression) 
        {
            var propertyName = ((MemberExpression)expression.Body).Member.Name;
            if (propertyName == nameof(Person.Address))
            {
                var result = new Address();
                return (T)(object)result;
            }
            else
            {
                var result = new Employment();
                return (T)(object)result;
            }
        }

        //создание экземпляра на основе значений свойств из словаря
        public Person Build()
        {
            return new Person
            (
                firstName: GetPropertyValue<string>(nameof(Person.FirstName), "Неизвестно"),
                lastName: GetPropertyValue<string>(nameof(Person.LastName), "Неизвестно"),
                address: new Address(),
                employment: new Employment()
            );
        }

        private T GetPropertyValue<T>(string propertyName, T defaultValue)
        {
            return _propertiesToBuild.TryGetValue(propertyName, out var value) ? (T)value : defaultValue;
        }
    }


    public class Address
    {
        public string City { get; set; }
        public int PostCode { get; set; }

        public override string ToString()
        {
            return $"Адрес: {City}-{PostCode} ";
        }
    }

    public class Employment
    {
        public string CompanyName { get; set; }
        public string Position { get; set; }
        public int AnnualIncome { get; set; }

        public override string ToString()
        {
            return $"Работа: {CompanyName}, должность: {Position}, зарплата: {AnnualIncome}";
        }
    }

    public class Person
    {
        public Person(string firstName, string lastName,
            Address address, Employment employment)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Employment = employment;
        }

        public string FirstName { get; }
        public string LastName { get; }
        public Address Address { get; }
        public Employment Employment { get; }

        public override string ToString()
        {
            return $"{FirstName} {LastName}: "
                + Environment.NewLine +
                $"{Address}"
                + Environment.NewLine +
                $"{Employment}";
        }
    }
}
