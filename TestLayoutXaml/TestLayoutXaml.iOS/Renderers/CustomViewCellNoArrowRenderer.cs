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
            var cell = base.GetCell(item, reusableCell, tv);

            // remove highlight on selected cell
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            return cell;
        }
    }
}