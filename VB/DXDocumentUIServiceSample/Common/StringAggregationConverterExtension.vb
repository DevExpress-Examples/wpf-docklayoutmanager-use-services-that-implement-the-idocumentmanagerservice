Imports System
Imports System.Windows.Markup

Namespace DXDocumentUIServiceSample.Common
	Public Class StringAggregationConverterExtension
		Inherits MarkupExtension

		Public Overrides Function ProvideValue(ByVal serviceProvider As IServiceProvider) As Object
			Return New StringAggregationConverter()
		End Function
	End Class
End Namespace
