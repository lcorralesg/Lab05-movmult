using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab05
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class LabelCode : ContentPage
	{
		public LabelCode ()
		{
			InitializeComponent ();
			var underlineLabel = new Label { Text = "This is an underlined label.", TextDecorations = TextDecorations.Underline };
			var strikeThroughLabel = new Label { Text = "This is a strikethrough label.", TextDecorations = TextDecorations.Strikethrough };
		}
	}
}