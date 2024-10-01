

namespace APITesting.Model {
    public class GetUserModel {
        public UserData Data { get; set; }
        public SupportModel Support { get; set; }
        public class UserData {
            public int Id { get; set; }
            public string Email { get; set; }
            public string First_name { get; set; }
            public string Last_name { get; set; }
            public string Avatar { get; set; }
        }


        public class SupportModel {
            public string Url { get; set; }
            public string Text { get; set; }
        }
    }
}
