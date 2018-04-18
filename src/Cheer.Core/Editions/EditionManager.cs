using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Domain.Repositories;

namespace Cheer.Editions
{
    /// <summary>
    /// 版本管理者
    /// </summary>
    public class EditionManager : AbpEditionManager
    {
        public const string DefaultEditionName = "Standard";

        public EditionManager(IRepository<Edition> editionRepository, IAbpZeroFeatureValueStore featureValueStore) : base(editionRepository, featureValueStore)
        {
        }
    }
}
