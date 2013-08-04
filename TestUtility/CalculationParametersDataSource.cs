using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using DataModel.Interfaces;

namespace TestUtility
{
	public class CalculationDataSource : UITableViewDataSource
	{
		ICalculationModel _data;
		public CalculationDataSource(ICalculationModel data)
		{
			_data = data;
		}

		#region implemented abstract members of UITableViewDataSource

		public override int RowsInSection (UITableView tableView, int section)
		{
			return 8; 
		}

		public override UITableViewCell GetCell (UITableView tableView, NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell ("data");
			if (cell == null)
				cell = new UITableViewCell ();

			cell.TextLabel.Text = _data.GetValue((ParamType)indexPath.Row);

			return cell;
		}

		#endregion


	}
}

