using System.Linq;
using AutoMapper;

namespace CSLAInputControls.Common.Helpers
{
    public static class AutoMapperHelper
    {
        public static string GetSourcePropertyNameFor<TSource, TDestination>(IMapper mapper, string destinationPropertyName)
        {
            var map = mapper.ConfigurationProvider.FindTypeMapFor<TSource, TDestination>();

            var propertyMap = map.PropertyMaps.FirstOrDefault(pm => pm.DestinationMember.Name == destinationPropertyName);

            return propertyMap?.SourceMember.Name ?? destinationPropertyName;
        }
    }
}
