using FluentBuilder;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

/**
 * Принятый ответ
 * 
 */


namespace FluentBuilderV2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Builder()
                               .Set(p => p.FirstName, "Андрей")
                               .Include(p => p.Address)
                               .Set(a => a.City, "Москва")
                               .Set(a => a.PostCode, 194356)
                               .Include(p => p.Employment)
                               .Set(e => e.AnnualIncome, 50000)
                               .Set(e => e.Position, "инженер")
                               .Include(p => p)
                               .Set(p => p.LastName, "Иванов")
                               .Build();

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }

    class Builder<T>
    {
        public Builder Root { get; }
        public Dictionary<string, object> Props { get; }

        public Builder(Builder root)
        {
            Root = root;
            Props = new Dictionary<string, object>();
        }

        public Builder<T> Set<TProp>(Expression<Func<T, TProp>> expression, TProp value)
        {
            var propertyName = ((MemberExpression)expression.Body).Member.Name;
            Props.Add(propertyName, value);
            return this;
        }

        public virtual Builder<TProp> Include<TProp>(Expression<Func<Person, TProp>> expression)
        {
            return Root.Include(expression);
        }

        public TProp GetPropertyValue<TProp>(string propertyName, TProp defaultValue)
        {
            return Props.TryGetValue(propertyName, out var value) ? (TProp)value : defaultValue;
        }

        public virtual Person Build()
        {
            return Root.Build();
        }
    }

    class Builder : Builder<Person>
    {
        private Builder<Address> _addressBuilder;
        private Builder<Employment> _employmentBuilder;

        public Builder()
            : base(null)
        {
            _addressBuilder = new Builder<Address>(this);
            _employmentBuilder = new Builder<Employment>(this);
        }

        public override Builder<TProp> Include<TProp>(Expression<Func<Person, TProp>> expression)
        {
            if (expression.Body is MemberExpression memberExpression)
            {
                var propName = memberExpression.Member.Name;
                return propName switch
                {
                    nameof(Person.Address) => _addressBuilder as Builder<TProp>,
                    nameof(Person.Employment) => _employmentBuilder as Builder<TProp>,
                    _ => throw new Exception("lolo")
                };
            }

            if (expression.Body is ParameterExpression parameterExpression && parameterExpression.Type == typeof(Person))
            {
                return this as Builder<TProp>;
            }

            throw new Exception("lolo");
        }

        public override Person Build()
        {
            return new Person
            (
                firstName: GetPropertyValue<string>(nameof(Person.FirstName), "!FirstName!"),
                lastName: GetPropertyValue<string>(nameof(Person.LastName), "!LastName!"),
                address: new Address()
                {
                    City = _addressBuilder.GetPropertyValue<string>(nameof(Address.City), "!City!"),
                    PostCode = _addressBuilder.GetPropertyValue<int>(nameof(Address.PostCode), -1),
                },
                employment: new Employment()
                {
                    CompanyName = _employmentBuilder.GetPropertyValue<string>(nameof(Employment.CompanyName), "!CompanyName!"),
                    Position = _employmentBuilder.GetPropertyValue<string>(nameof(Employment.Position), "!Position!"),
                    AnnualIncome = _employmentBuilder.GetPropertyValue<int>(nameof(Employment.AnnualIncome), -1),
                }
            );
        }
    }
}
