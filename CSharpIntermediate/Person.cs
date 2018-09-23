using System;

namespace CSharpIntermediate
{
    public class Person
    {
        public DateTime Birthdate { get; private set; }

        public Person(DateTime birthdate)
        {
            Birthdate = birthdate;
        }

        public DateTimeOffset Age
        {
            get
            {
                var offset = DateTimeOffset.MinValue;
                var timeSpanDifference = DateTime.Today - Birthdate;
                var resultWithOffset = DateTimeOffset.MinValue.AddDays(timeSpanDifference.TotalDays);
                var result = resultWithOffset.AddDays(-offset.Day).AddMonths(-offset.Month).AddYears(-offset.Year);

                return result;
            }
        }
    }
}