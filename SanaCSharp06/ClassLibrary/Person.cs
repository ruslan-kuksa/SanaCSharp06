﻿namespace ClassLibrary
{
    public class Person
    {
        protected string _name { get; set; }
        protected string _surname { get; set; }
        protected DateTime _dateTime { get; set; }
        public Person() { }
        public Person (string name, string surname, DateTime dateTime)
        {
            _name = name;
            _surname = surname;
            _dateTime = dateTime;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Ім'я: {_name}");
            Console.WriteLine($"Прізвище: {_surname}");
            Console.WriteLine($"Дата народження: {_dateTime.Year}.{_dateTime.Month}.{_dateTime.Day}.");
        }
    }
}