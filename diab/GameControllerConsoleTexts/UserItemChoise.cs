namespace diab
{
    public class UserItemChoise
    {
        /// <summary>
        /// display choise and return int 1-3
        /// </summary>
        /// <returns></returns>
        public static int GetUserInput()
        {
            while (true)
            {
                Console.WriteLine("Choose from 1-3");
                int userOption = int.Parse(Console.ReadLine()!);
                if (userOption> 0 && userOption < 4)
                {
                    return userOption;
                }
                continue;
            }
        }
    }
}
