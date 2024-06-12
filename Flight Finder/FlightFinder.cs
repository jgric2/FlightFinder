namespace Flight_Finder
{
    public static class FlightFinder
    {
        const int FlightWordLength = 6;
      
        public static int FindFlightInstances(string input, int maxLength = 100)
        {
            //Exit if the input is less than the length of flight, it is impossible to have a match
            if (input.Length < FlightWordLength)
                return 0;

            //We assume the input is lowercase, however it would be trivial to cast this toLower for safety.
            //Convert our input to a ReadOnlySpan for performance
            ReadOnlySpan<char> possibleFlightPart = input.Length > maxLength ? input.AsSpan(0, maxLength) : input.AsSpan();

            //Since the amount of characters is small, I am using individual ints to measure the count of characters to avoid array lookup overhead
            int f = 0, l = 0, i = 0, g = 0, h = 0, t = 0;

            //Below we check each character in the possibleFlightPath, if it matches any character of 'flight' we increment the appropriate counter
            foreach (char c in possibleFlightPart)
            {
                switch (c)
                {
                    case 'f': 
                        ++f; 
                        break;
                    case 'l': 
                        ++l; 
                        break;
                    case 'i': 
                        ++i; 
                        break;
                    case 'g':
                        ++g; 
                        break;
                    case 'h': 
                        ++h; 
                        break;
                    case 't': 
                        ++t;
                        break;
                }
            }

            //From here it is a simple process of returning the smallest of our individual characters which will give us the number of times we can make the word flight with the input string.
            int smallestNumberOfFlightInstances = Math.Min(f, Math.Min(l, Math.Min(i, Math.Min(g, Math.Min(h, t)))));
            return smallestNumberOfFlightInstances;
        }
    }
}
