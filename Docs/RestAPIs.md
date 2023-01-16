

> 😃 How would I use 3rd party REST APIs in C# with the `System.Net.Http` and `System.Text.Json` libraries?
​>
> 🤖 You can use the `System.Net.Http` library to make HTTP requests to a REST API and the `System.Text.Json` library to parse the JSON response. Here is an example of how you can use these libraries to make a GET request to a REST API and parse the JSON response:

```csharp
using System.Net.Http;
using System.Text.Json;

// Create a new HttpClient instance
using (var client = new HttpClient())
{
    // Send a GET request to the API
    var response = await client.GetAsync("https://jsonplaceholder.typicode.com/posts/1");
    
    // Check if the request was successful
    if (response.IsSuccessStatusCode)
    {
        // Read the response content as a string
        var json = await response.Content.ReadAsStringAsync();
        
        // Deserialize the JSON to a dynamic object
        var data = JsonSerializer.Deserialize<dynamic>(json);
        
        // Access the properties of the object
        var id = data.id;
        var title = data.title;
    }
}
```

​>
> 🤖 You can also use `JsonSerializer.Deserialize<T>` to deserialize the json to a strongly typed object, where T is the type of your object.
​>
> 🤖 Please note that this is just an example, and you will need to replace the URL and the object type based on your API endpoint and the expected response structure.




dagilleland@shaw.ca
Do you know which GitHub API calls do not require authentication?
​>
> 🤖 Yes, some of the GitHub API calls do not require authentication. These include:
​>
> - Retrieving public information about a user: `GET /users/{username}`
> - Retrieving public information about a repository: `GET /repos/{owner}/{repo}`
> - Retrieving a list of public repositories for a user: `GET /users/{username}/repos`
> - Retrieving a list of all public repositories: `GET /repositories`
> - Searching for repositories: `GET /search/repositories`
​>
> 🤖 However, please keep in mind that unauthenticated requests are limited by the API's rate limit, which is much lower than for authenticated requests. Also, some information about a repository or user that is private may not be accessible without authentication.
​>
> 🤖 Additionally, if you want to perform any write operation such as creating a new repository, editing a repository, creating a new issue, etc. you must have an authenticated session, using your GitHub personal access token.

