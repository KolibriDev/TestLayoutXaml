using TestLayout.iOS.Renderers;

using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(ViewCell), typeof(CustomViewCellRenderer))]


namespace TestLayout.iOS.Renderers
{
    
    public class CustomViewCellRenderer : ViewCellRenderer
    {
        public override UITableViewCell GetCell(Cell item, UITableViewCell reusableCell, UITableView tv)
        {
            var cell = base.GetCell(item, reusableCell, tv);

            // remove highlight on selected cell
            cell.SelectionStyle = UITableViewCellSelectionStyle.None;

            // iOS right arrow
            cell.Accessory = UITableViewCellAccessory.DisclosureIndicator; 

            return cell;
        }
    }
}
