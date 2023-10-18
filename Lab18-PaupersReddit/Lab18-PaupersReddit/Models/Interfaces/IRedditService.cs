namespace Lab18_PaupersReddit.Models.Interfaces;

public interface IRedditService
{
    Task<List<ChildrenData>> GetRedditPostsAsync();
}