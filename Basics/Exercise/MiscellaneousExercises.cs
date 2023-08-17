namespace CSharpExercisesFirstTry.Exercise
{
    internal class MiscellaneousExercises
    {
        public MiscellaneousExercises()
        {
        }

        internal int HowManyDays(DateTime past, DateTime now)
        {
            /* Exercise text:
             * Given two dates - first from the past and second as present date, write a method that returns numbers of days between these two dates.
                Expected input and output
                HowManyDays((2006, 1, 31), Now) → 4652
             */

            int howManyYearsBetweenPastAndPresent = now.Year - past.Year;
            int pastMonth = past.Month;
            int unevenMonthsPast = 0;
            int evenMonthPast = 0;
            int unevenMonthsNow = 0;
            int evenMonthNow = 0;

            for (int i = past.Month; i < 12 ; i++)
            {
                if(i % 2 == 0)
                {
                    evenMonthPast++;
                }
                else
                {
                    unevenMonthsPast++;
                }
            }

            for (int i =1; i < now.Month; i++)
            {
                if (i % 2 == 0)
                {
                    evenMonthNow++;
                }
                else
                {
                    unevenMonthsNow++;
                }
            }

            // PSUDOCODE : totaldays = (days for past year left) + (years between now and past in days) + (days for last year left till date end incl end date)

            int totalDays = -1;
            int pastDays = 1+ (31 - past.Day) + (unevenMonthsPast * 31) + (evenMonthPast * 30); 
            int yearInBetween = (365 * (howManyYearsBetweenPastAndPresent - 1));
            int daysInLastYear = (now.Day + (unevenMonthsNow * 31) + (evenMonthNow * 30));
            totalDays = pastDays + yearInBetween + daysInLastYear;

            return totalDays;
        }
    }
}