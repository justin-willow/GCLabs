using Lab18_PaupersReddit.Models.Interfaces;

namespace Lab18_PaupersReddit.Models.Services;

public class RedditService : IRedditService
{
    public async Task<List<ChildrenData>> GetRedditPostsAsync()
    {
        string apiUrl = "https://www.reddit.com/r/aww/.json";

        using (HttpClient client = new HttpClient())
        {
            client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/123.0.0.1 Safari/537.36");

            try
            {
                Response response = await client.GetFromJsonAsync<Response>(apiUrl);

                if (response?.data?.children == null)
                {
                    return new List<ChildrenData>();
                }
                List<ChildrenData> posts = response.data.children
                    .Select(child => new ChildrenData
                    {
                        title = child.data.title,
                        thumbnail = child.data.thumbnail,
                        url = child.data.url
                    })
                    .Take(10)
                    .ToList();

                return posts;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        return new List<ChildrenData>();
    }
}