namespace CMSCore.Library.GrainInterfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CMSCore.Library.Messages;
    using Messages.Read;
    using Orleans;
    using Orleans.Concurrency;

    public interface IReadContentGrain : IGrainWithStringKey
    {
        Task<FeedItemViewModel> GetFeedItem();
        Task<FeedItemViewModel> GetFeedItemByNormalizedName();
        Task<PageViewModel> GetPageById();
        Task<PageViewModel> GetPageByNormalizedName();
        Task<List<PageTreeViewModel>> GetPageTree();
        Task<List<TagViewModel>> GetTags();
        Task<List<UserViewModel>> GetUsers();
    }
}