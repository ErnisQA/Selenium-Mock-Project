using System.Configuration;

namespace TestFrameworkCore.Helper {
    public class ConfigurationHelper {
        public static T? GetConfig<T>(string key) {
            try {
                var value = ConfigurationManager.AppSettings[key];
                if (value is null) {
                    return default(T);
                }
                return (T)Convert.ChangeType(value, typeof(T));
            }
            catch (InvalidCastException ex) {
                // Handle invalid cast exception
                Console.WriteLine($"Invalid cast for key: {key}. Exception: {ex.Message}");
                return default(T);
            }
            catch (FormatException ex) {
                // Handle format exception when trying to convert types
                Console.WriteLine($"Format issue for key: {key}. Exception: {ex.Message}");
                return default(T);
            }
            catch (Exception ex) {
                // Catch any other exceptions
                Console.WriteLine($"Error retrieving config for key: {key}. Exception: {ex.Message}");
                return default(T);
            }
        }
    }
}
