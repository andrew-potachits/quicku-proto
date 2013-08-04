using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TestUtility
{
	public class CalculationModel : ICalculationModel
	{
		#region ICalculationModel implementation

		public void Reset ()
		{
			throw new NotImplementedException ();
		}

		public bool HasMultipleValues (ParamType paramType)
		{
			throw new NotImplementedException ();
		}

		public string GetText (ParamType paramType)
		{
			throw new NotImplementedException ();
		}

		#endregion

		ICalculationData _dataSource;

		public CalculationModel (ICalculationData dataSource)
		{
			_dataSource = dataSource;
		}

	}
}

