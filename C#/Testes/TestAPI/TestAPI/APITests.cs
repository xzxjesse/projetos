namespace TestAPI
{
    using RestSharp;
    using Xunit;
    using System.Net;

    public class APITests
    {
        private const string BaseUrl = "https://66d9f22a4ad2f6b8ed568b83.mockapi.io/api/Jesse/";
        private readonly RestClient _client;

        public APITests()
        {
            _client = new RestClient(BaseUrl);
        }

        //status code
        [Fact]
        public void Test_GetAllUsers()
        {
            var request = new RestRequest("users", Method.Get);

            var response = _client.Execute<User>(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        //buscar dados de um id
        [Fact]
        public void Test_GetUsuarioPorID()
        {
            var request = new RestRequest("users/2", Method.Get);
            
            var response = _client.Execute<User>(request);
            
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.Equal(2, response.Data.id); 
            Assert.Equal("Rosa Steuber", response.Data.name); 
            Assert.Equal("Cuba", response.Data.country);
            Assert.Equal("Genderqueer", response.Data.gender);
            Assert.True(response.Data.active);
        }

        //buscar ativos
        [Fact]
        public void Test_GetUsuariosAtivos()
        {
            var request = new RestRequest("users", Method.Get);

            var response = _client.Execute<List<User>>(request);
            var activeUsers = response.Data.Where(u => u.active).ToList();

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.True(activeUsers.All(u => u.active));

            int expectedActiveUsersCount = 7;
            Assert.Equal(expectedActiveUsersCount, activeUsers.Count);
        }

        //buscar um null
        public void Test_GetUsuarioNull()
        {
            var request = new RestRequest("users/30", Method.Get);

            var response = _client.Execute<User>(request);

            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
            Assert.Null(response.Data);
        }

        //criar 
        [Fact]
        public void Test_PostUsuario()
        {
            var request = new RestRequest("users", Method.Post);

            var newUser = new User
            {
                name = "John Doe",
                gender = "Non-binary",
                country = "Brazil",
                active = true,
                id = 16
            };

            request.AddJsonBody(newUser);

            var response = _client.Execute<User>(request);

            Assert.Equal(HttpStatusCode.Created, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.Equal(16, response.Data.id);
            Assert.Equal("John Doe", response.Data.name);
            Assert.Equal("Non-binary", response.Data.gender);
            Assert.Equal("Brazil", response.Data.country);
            Assert.True(response.Data.active);
        }

        //alterar
        [Fact]
        public void Test_PatchUsuarioPorID()
        {
            var request = new RestRequest("users/16", Method.Patch);

            var updatedData = new { active = false };

            request.AddJsonBody(updatedData);

            var response = _client.Execute<User>(request);

            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
            Assert.NotNull(response.Data);
            Assert.Equal(16, response.Data.id);
            Assert.False(response.Data.active);
        }


        //deletar
        [Fact]
        public void Test_DeleteUsuarioPorID()
        {
            var request = new RestRequest("users/17", Method.Delete);

            var response = _client.Execute(request);

            Assert.Equal(HttpStatusCode.NoContent, response.StatusCode); 
        }
    }
}