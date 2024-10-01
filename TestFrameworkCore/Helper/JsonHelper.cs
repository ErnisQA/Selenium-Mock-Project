using MockProject.Model;
using Newtonsoft.Json;

namespace TestFrameworkCore.Helper {
    public class JsonHelper {

        public static List<EmployeesModel> ReadDataFromFile(string filePath) {
            try {
                // Check if the file exists before attempting to read
                if (!File.Exists(filePath)) {
                    throw new FileNotFoundException("The specified file was not found.", filePath);
                }

                // Read the JSON content from the file
                string json = File.ReadAllText(filePath);

                // Deserialize the JSON content into a list of EmployeesModel
                List<EmployeesModel> employeesModel = JsonConvert.DeserializeObject<List<EmployeesModel>>(json);

                // Ensure the deserialization result is not null
                if (employeesModel == null) {
                    throw new InvalidOperationException("Failed to deserialize the JSON file. The result is null.");
                }

                return employeesModel;
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine($"Error: {ex.Message}");
                return new List<EmployeesModel>(); // Return an empty list if the file is not found
            }
            catch (JsonSerializationException ex) {
                Console.WriteLine($"Error deserializing the JSON content: {ex.Message}");
                return new List<EmployeesModel>(); // Return an empty list if there's a JSON deserialization issue
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return new List<EmployeesModel>(); // Return an empty list for any other errors
            }
        }
    }
}
