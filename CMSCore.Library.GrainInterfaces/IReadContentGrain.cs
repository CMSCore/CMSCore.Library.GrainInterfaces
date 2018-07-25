namespace CMSCore.Library.GrainInterfaces
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CMSCore.Library.Messages;
    using Orleans;

    public interface IReadContentGrain : IGrainWithStringKey
    {
        Task<FeedItemViewModel> GetFeedItem();
        Task<FeedItemViewModel> GetFeedItemByNormalizedName();
        Task<PageViewModel> GetPageById();
        Task<PageViewModel> GetPageByNormalizedName();
        Task<IEnumerable<PageTreeViewModel>> GetPageTree();
        Task<IEnumerable<TagViewModel>> GetTags();
        Task<IEnumerable<UserViewModel>> GetUsers();
    }
}