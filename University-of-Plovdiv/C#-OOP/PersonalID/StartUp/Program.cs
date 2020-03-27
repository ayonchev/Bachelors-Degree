using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace StartUp
{
    class Program
    {
        static void Main()
        {
            string egn = Console.ReadLine();
            DateTime dateOfBirth;
            Gender gender;

            try
            {
                GetDataFromEgn(egn, out dateOfBirth, out gender);
                Console.WriteLine($"Date of birth - {dateOfBirth.ToString("dd.MM.yyyy")}");
                Console.WriteLine($"Gender - {gender}");

            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid EGN!");
            }
        }

        //I made the method to throw format exception rather than to return a boolean value, because I think that it's more appropriate and easier to manipulate.
        private static void GetDataFromEgn(string egn, out DateTime dateOfBirth, out Gender gender)
        {
            Regex regex = new Regex(@"^(?<year>\d{2})(?<month>\d{2})(?<day>\d{2})\d{2}(?<gender>\d)\d$");
            var match = regex.Match(egn);

            dateOfBirth = default(DateTime);
            gender = default(Gender);

            if (!match.Success)
            {
                throw new FormatException();
            }

            int year = 1900 + int.Parse(match.Groups["year"].Value);
            int month = int.Parse(match.Groups["month"].Value);
            int day = int.Parse(match.Groups["day"].Value);

            GetBirthYear(ref year, ref month);

            int genderNumber = int.Parse(regex.Match(egn).Groups["gender"].Value);

            dateOfBirth = DateTime.Parse($"{month}.{day}.{year}");
            gender = GetGender(genderNumber);
        }

        private static void GetBirthYear(ref int year, ref int month)
        {
            if (month - 20 <= 12 && month - 20 > 0)
            {
                year -= 100;
                month -= 20;
            }
            else if (month - 40 <= 12 && month - 40 > 0)
            {
                year += 100;
                month -= 40;
            }
            else if ((month > 12 && month < 21) ||
                    (month > 32 && month < 41) ||
                     month > 52)
            {
                year = -1;
            }
        }

        private static Gender GetGender(int genderNumber)
        {
            if (genderNumber % 2 == 0)
                return Gender.Male;

            return Gender.Female;
        }
    }
}

