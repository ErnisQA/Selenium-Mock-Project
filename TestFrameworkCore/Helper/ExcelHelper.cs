using OfficeOpenXml;

namespace TestFrameworkCore.Helper {
    public class ExcelHelper {
        private string filePath;
        public ExcelHelper(string _filePath) {
            filePath = _filePath;
        }
        public List<object[]> GetProjectsData() {
            var result = new List<object[]>();

            try {
                // Ensure the license context is set for non-commercial use
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                // Open the Excel file using the file path (you may need to pass filePath as a parameter or set it globally)
                using (var package = new ExcelPackage(new FileInfo(filePath))) {
                    // Get the first worksheet from the workbook
                    var workSheet = package.Workbook.Worksheets.FirstOrDefault();
                    if (workSheet == null) {
                        throw new Exception("No worksheets found in the Excel file.");
                    }

                    // Get the first table within the worksheet
                    var table = workSheet.Tables.FirstOrDefault();
                    if (table == null) {
                        throw new Exception("No tables found in the worksheet.");
                    }

                    // Get total number of rows and columns
                    var totalRow = table.Range.Rows;
                    var totalColumn = table.Range.Columns;

                    // Loop through the rows, starting from the second row (assuming first is a header)
                    for (var i = 2; i <= totalRow; i++) {
                        result.Add(new object[]
                        {
                    workSheet.Cells[i, 1].Value?.ToString() ?? string.Empty,
                    workSheet.Cells[i, 2].Value?.ToString() ?? string.Empty,
                    workSheet.Cells[i, 3].Value?.ToString() ?? string.Empty,
                    workSheet.Cells[i, 4].Value?.ToString() ?? string.Empty,
                    workSheet.Cells[i, 5].Value?.ToString() ?? string.Empty
                        });
                    }
                }
            }
            catch (FileNotFoundException ex) {
                Console.WriteLine($"File not found: {ex.Message}");
            }
            catch (IOException ex) {
                Console.WriteLine($"Error reading file: {ex.Message}");
            }
            catch (Exception ex) {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            return result;
        }
    }
}
