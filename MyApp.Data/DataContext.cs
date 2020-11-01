using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using MyApp.Models;

namespace MyApp.Data
{
    public class DataContext
    {
        public DataContext()
        {
            Users = new List<User>
            {
                new User { Id = 1, Forename = "Grant", Surname = "Cooper", IsActive = true, DateOfBirth = new DateTime(1979, 07, 28)},
                new User { Id = 2, Forename = "Tom", Surname = "Gathercole", IsActive = false , DateOfBirth = new DateTime(2009, 07, 21)},
                new User { Id = 3, Forename = "Mark", Surname = "Edmondson", IsActive = false,  DateOfBirth = new DateTime(1993, 07, 1) },
                new User { Id = 4, Forename = "Graham", Surname = "Clark", IsActive = true,  DateOfBirth = new DateTime(2009, 07, 1)}
            };
        }

        private List<User> Users { get; set; }



        public List<TEntity> Set<TEntity>() where TEntity : class 
        {
            var propertyInfo = PropertyInfos.FirstOrDefault(p => p.PropertyType == typeof(List<TEntity>));


            if (propertyInfo != null)
            {
                // Get the List<T> from 'this' Context instance
                var x = propertyInfo.GetValue(this, null) as List<TEntity>;

                return x;
            }
             
            throw new Exception("Type collection not found");
        }


        private IEnumerable<PropertyInfo> _propertyInfos;
        private IEnumerable<PropertyInfo> PropertyInfos
        {
            get
            {
                return _propertyInfos ??
                        (_propertyInfos = GetType()
                                            .GetProperties(BindingFlags.Instance | BindingFlags.NonPublic)
                                            .Where(p => p.PropertyType.IsGenericType &&
                                                        p.PropertyType.GetGenericTypeDefinition() == typeof(List<>)));
            }
        }

    }
}
