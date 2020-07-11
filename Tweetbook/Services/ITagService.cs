using System.Collections.Generic;
using System.Threading.Tasks;
using Tweetbook.Domain;

namespace Tweetbook.Services
{
    public interface ITagService
    {
        Task<List<Tag>> GetAllTagsAsync();

        Task<bool> CreateTagAsync(Tag tag);

        Task<Tag> GetTagByNameAsync(string tagName);

        Task<bool> DeleteTagAsync(string tagName);
    }
}