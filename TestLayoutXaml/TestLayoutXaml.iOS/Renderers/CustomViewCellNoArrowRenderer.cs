using TestLayout.iOS.Renderers;
using TestLayoutXaml;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCellNoArrow), typeof(CustomViewCellNoArrowRenderer))]


namespace TestLayout.iOS.Renderers
{

    public class CustomViewCellNoArrowRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
			// The following fixes the spinner problem
			// ======
			/*
			 var viewCell = item as ViewCell;
			var view = viewCell.View;
			if (view is ContentView)
			{
				var contentView = view as ContentView;
				if (contentView.Content is ActivityIndicator)
				{
					var spinner = (ActivityIndicator)contentView.Content;
					spinner.IsRunning = false;
					spinner.IsRunning = true;
				}
			}
			*/
			// ======

            var cell = base.GetCell(item, reusableCell, tv);

            // remove highlight on selected cell
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}