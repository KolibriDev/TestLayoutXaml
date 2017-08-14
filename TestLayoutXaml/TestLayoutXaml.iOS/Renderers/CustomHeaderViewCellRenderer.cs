using TestLayout.iOS.Renderers;
using TestLayoutXaml;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(HeaderViewCell), typeof(CustomHeaderViewCellRenderer))]


namespace TestLayout.iOS.Renderers
{
    
    public class CustomHeaderViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            // remove highlight on selected cell
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}
