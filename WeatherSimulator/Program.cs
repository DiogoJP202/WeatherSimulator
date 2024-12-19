namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of days to simulate: ");
            int days = int.Parse(Console.ReadLine());

            int[] temperature = new int[days];
            string[] conditions = {"Sunny", "Rainy", "Cloudy", "Snowy"};
            string[] weatherConditions = new string[days];

            Random random = new Random();
            
            for (int i = 0; i < days; i++)
            {
                temperature[i] = random.Next(-10, 40);
                if (temperature[i] <= 0)
                    weatherConditions[i] = conditions[3];
                else
                    weatherConditions[i] = conditions[random.Next(conditions.Length - 1)];
            }

            Console.WriteLine("The average temperature is " + AverageNumber(temperature));
            Console.WriteLine($"The max temperature was: {MaxTemperature(temperature)}");
            Console.WriteLine($"The min temperature was: {MinTemperature(temperature)}");
            Console.WriteLine($"The most common condition is: {MostCommonCondition(weatherConditions)}");
            Console.ReadKey();
        }

        static double AverageNumber(int[] numberList)
        {
            int sum = 0;

            foreach (int number in numberList)
            {
                sum += number;
            }

            double avarege = (double)sum / numberList.Length;

            return avarege;
        }

        static int MinTemperature(int[] temperatures)
        { 
            int min = temperatures[0];

            foreach (int temperature in temperatures)
            { 
                if (temperature < min)
                    min = temperature;
            }

            return min;
        }

        static int MaxTemperature(int[] temperatures)
        {
            int min = temperatures[0];

            foreach (int temperature in temperatures)
            {
                if (temperature > min)
                    min = temperature;
            }

            return min;
        }

        static string MostCommonCondition(string[] conditions)
        {
            int count = 0;
            string mostCommun = conditions[0];

            for (int i = 0; i < conditions.Length; i++)
            {
                int tempCount = 0;

                for (int j = 0; j < conditions[i].Length; j++)
                {
                    if (conditions[j] == conditions[i])
                        tempCount++;
                }

                if (tempCount > count)
                {
                    count = tempCount;
                    mostCommun = conditions[i];
                }
            }

            return mostCommun;
        }
    }
}
