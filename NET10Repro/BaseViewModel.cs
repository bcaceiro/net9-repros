using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace NET10Repro
{
    public class BaseViewModel : INotifyPropertyChanged, IQueryAttributable
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        private Person _currentPerson;

        public Person CurrentPerson
        {
            get => _currentPerson;
            set => SetProperty(ref _currentPerson, value);
        }

        public BaseViewModel()
        {
        }

        public void ApplyQueryAttributes(IDictionary<string, object> query)
        {
            if (query != null && query.ContainsKey("CurrentPerson"))
            {
                CurrentPerson = query["CurrentPerson"] as Person;
            }
        }

        protected void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        protected bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string? propertyName = null)
        {
            if (Equals(storage, value))
            {
                return false;
            }

            storage = value;

            if (propertyName != null)
            {
                OnPropertyChanged(propertyName);
            }

            return true;
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Id { get; set; }
    }
}