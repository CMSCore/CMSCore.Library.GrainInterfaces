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
        Task<Immutable<FeedItemViewModel>> GetFeedItem();
        Task<Immutable<FeedItemViewModel>> GetFeedItemByNormalizedName();
        Task<Immutable<PageViewModel>> GetPageById();
        Task<Immutable<PageViewModel>> GetPageByNormalizedName();
        Task<Immutable<PageTreeViewModel[]>> GetPageTree();
        Task<Immutable<TagViewModel[]>> GetTags();
        Task<Immutable<UserViewModel[]>> GetUsers();
    }
}