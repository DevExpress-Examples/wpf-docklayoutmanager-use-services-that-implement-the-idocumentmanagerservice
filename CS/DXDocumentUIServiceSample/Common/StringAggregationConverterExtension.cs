using System;
using System.Windows.Markup;

namespace DXDocumentUIServiceSample.Common {
    public class StringAggregationConverterExtension : MarkupExtension {
        public override object ProvideValue(IServiceProvider serviceProvider) {
            return new StringAggregationConverter();
        }
    }
}
