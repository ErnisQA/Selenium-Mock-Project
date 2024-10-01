
using System.Text;

namespace TestFrameworkCore.Helper {
    public class RandomHelper {
        public static string RandomText() {
            int length = 10; // Length of the random string
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789"; // Characters to choose from
            StringBuilder sb = new StringBuilder();

            for (int i = 0; i < length; i++) {
                sb.Append(chars[random.Next(chars.Length)]);
            }

            string randomString = sb.ToString();
            return randomString;
        }

        public static string RandomNumber() {
            int random = new Random().Next(0, 500);
            string randomNumber = random.ToString();
            return randomNumber;
        }

        public static string RandomDate() {
            // Create a random generator
            Random random = new Random();

            // Random Year:
            int year = random.Next(2020, 2050);

            // Random Month:
            int month = random.Next(1, 13);

            // Random Day:
            int maxDay = DateTime.DaysInMonth(year, month);
            int day = random.Next(1, maxDay + 1);

            // Combine and To String: 
            DateTime randomDate = new DateTime(year, month, day);
            string formattedRandomDate = randomDate.ToString("yyyy/MM/dd");

            return formattedRandomDate;
        }
    }
}
