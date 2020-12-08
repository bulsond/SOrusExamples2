using FluentBuilder;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;

/*
 * нерабочий вариант
 * 
 */


namespace FluentBuilderV1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new FluentBuilder<Person>()
                .Set(p => p.FirstName, "Андрей")
                .Set(p => p.LastName, "Иванов")
                .Include(p => p.Address)
                .Set(a => a.City, "Москва")
                .As<Person>()
                .Include(p => p.Employment)
                .Set(e => e.Position, "инженер")
                .As<Person>()
                .Build();

            Console.WriteLine(person);
            Console.ReadLine();
        }
    }

    class FluentBuilder<T>
    {
        private readonly Dictionary<Type, Dictionary<string, object>> _container;

        private Dictionary<string, object> _properties
        {
            get
            {
                if (!_container.TryGetValue(typeof(T), out var properties))
                {
                    properties = new Dictionary<string, object>();
                    _container[typeof(T)] = properties;
                }
                return properties;
            }
        }

        public FluentBuilder()
            => _container = new Dictionary<Type, Dictionary<string, object>>();

        public FluentBuilder(Dictionary<Type, Dictionary<string, object>> props)
            => _container = props;

        public FluentBuilder<Tprop> As<Tprop>() where Tprop : class
        {
            return new FluentBuilder<Tprop>(_container);
        }

        public FluentBuilder<T> Set<Tprop>(Expression<Func<T, Tprop>> expression, Tprop value)
        {
            var propertyName = ((MemberExpression)expression.Body).Member.Name;
            _properties.Add(propertyName, value);
            return this;
        }

        public FluentBuilder<Tprop> Include<Tprop>(Expression<Func<T, Tprop>> expression) where Tprop : class
        {
            var propertyName = ((MemberExpression)expression.Body).Member.Name;
            _properties.Add(propertyName, _properties);
            return As<Tprop>();
        }


        private object GetInstance(Type type)
        {
            //ошибка здесь из-за конструктора
            object result = Activator.CreateInstance(type); //требует конструктор без параметров
            Dictionary<string, object> props = _container[type];
            foreach (PropertyInfo p in type.GetProperties())
                if (props.TryGetValue(p.Name, out object v))
                    result.GetType().GetProperty(p.Name).SetValue(result, v == props ? GetInstance(p.PropertyType) : v);
            return result;
        }

        public T Build()
        {
            // для отладки, можно убрать
            foreach (Type t in _container.Keys)
                foreach (string s in _container[t].Keys)
                    Console.WriteLine($"[{t.Name}] {s}");

            return (T)GetInstance(typeof(T));
        }
    }
}
