namespace CMSCore.Library.GrainInterfaces
{
    using System.Threading.Tasks;
    using CMSCore.Library.Messages;
    using Messages.Create;
    using Messages.Read;
    using Messages.Update;
    using Orleans;

    public interface IManageContentGrain : IGrainWithStringKey
    {
        Task<string> CreateComment(CreateCommentViewModel model);
        Task<string> CreateFeed(CreateFeedViewModel model);
        Task<string> CreateFeedItem(CreateFeedItemViewModel model);
        Task<string> CreatePage(CreatePageViewModel model);
        Task<string> CreateUser(CreateUserViewModel model);

        Task<int> DeleteComment(string id);
        Task<int> DeleteContent(string id);
        Task<int> DeleteContentVersion(string id);
        Task<int> DeleteFeed(string id);
        Task<int> DeleteFeedItem(string id);
        Task<int> DeletePage(string id);
        Task<int> DeleteTag(string id);

        Task<string> UpdateContent(UpdateContentViewModel model);
        Task<string> UpdateFeedItem(UpdateFeedItemViewModel model);
        Task<string> UpdatePage(UpdatePageViewModel model);
    }
}