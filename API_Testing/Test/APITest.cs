
using APITesting.Model;
using FluentAssertions;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace APITesting.Test {
    public class APITest {
        private RestClient client;

        public APITest() {
            var url = "https://reqres.in/";
            client = new RestClient(url);
        }


        [Fact(DisplayName = "TC01: Verify Register Unsuccessful with 404 status code")]
        public void VerifyRegisterUnsuccessful() {
            try {
                var request = new RestRequest("/api/register", Method.Post);
                var requestModel = new RegisterUserModel {
                    Email = "sydney@fife"
                };
                request.AddJsonBody(requestModel);

                RestResponse response = client.Execute(request);

                // Verify Error Message is displayed:
                var responseModel = JsonConvert.DeserializeObject<RegisterUserModel>(response.Content);
                responseModel.Error.Should().Be("Missing password");

                // Verify Status code (400):
                response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
            }
            catch (JsonSerializationException ex) {
                Console.WriteLine($"Error deserializing the response: {ex.Message}");
                throw new Exception("Failed to deserialize the API response.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                throw; // Re-throw the original exception
            }
        }



        [Fact(DisplayName = "TC02: Verify Login Successful and verify SUT will be return token string")]
        public void VerifyLoginSuccessful() {
            try {
                var request = new RestRequest("/api/register", Method.Post);
                var requestModel = new LoginUserModel {
                    Email = "eve.holt@reqres.in",
                    Password = "cityslicka"
                };
                request.AddJsonBody(requestModel);
                RestResponse response = client.Execute(request);

                // Verify Status code (200):
                response.StatusCode.Should().Be(HttpStatusCode.OK);

                // Verify SUT will return token string:
                var responseModel = JsonConvert.DeserializeObject<LoginUserModel>(response.Content);

                // Verify token will return string type:
                responseModel.Token.Should().BeOfType<string>();
            }
            catch (JsonSerializationException ex) {
                Console.WriteLine($"Error deserializing the response: {ex.Message}");
                throw new Exception("Failed to deserialize the API response.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                throw; // Re-throw the original exception
            }
        }



        [Fact(DisplayName = "TC03: Verify Get Single User by random id and verify data.id is equal with random id")]
        public void VerifyGetRandomUserID() {
            try {
                int randomID = new Random().Next(1, 11);
                var request = new RestRequest($"/api/users/{randomID}", Method.Get);
                RestResponse response = client.Execute(request);

                // Verify Status code (200):
                response.StatusCode.Should().Be(HttpStatusCode.OK);

                // Verify data.id is equal to the random ID:
                var model = JsonConvert.DeserializeObject<GetUserModel>(response.Content);
                model.Data.Id.Should().Be(randomID);
            }
            catch (JsonSerializationException ex) {
                Console.WriteLine($"Error deserializing the response: {ex.Message}");
                throw new Exception("Failed to deserialize the API response.", ex);
            }
            catch (Exception ex) {
                Console.WriteLine($"An unexpected error occurred: {ex.Message}");
                throw; // Re-throw the original exception
            }

        }
    }
}
