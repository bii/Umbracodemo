using Umbraco.Core.Models.PublishedContent;
using Umbraco.Core.PropertyEditors;
using UmbracoDemo.Models;

namespace UmbracoDemo.PropertyValueConverters
{
    public class CustomLinkPickerPropertyValueConverter : IPropertyValueConverter
    {
        private readonly CustomLink customLink = new CustomLink();

        public object ConvertDataToSource(PublishedPropertyType propertyType, object source, bool preview)
        {
            return source;
        }

        public object ConvertSourceToObject(PublishedPropertyType propertyType, object source, bool preview)
        {
            return customLink.Deserialize(source as string);
        }

        public object ConvertSourceToXPath(PublishedPropertyType propertyType, object source, bool preview)
        {
            return null;
        }

        public bool IsConverter(PublishedPropertyType propertyType)
        {
            return propertyType.PropertyEditorAlias == "custom.link.picker";
        }
    }
}