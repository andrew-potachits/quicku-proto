using System;
using DataModel.Interfaces;


namespace DataModel
{
	public class CalculationModel : ICalculationModel
	{
		#region ICalculationModel implementation

		public void Reset ()
		{
			throw new NotImplementedException ();
		}

		public void Calculate ()
		{
			throw new NotImplementedException ();
		}

		public System.Collections.Generic.IEnumerable<ParamType> GetUnselected ()
		{
			throw new NotImplementedException ();
		}

		public bool HasMultipleValues (ParamType paramType)
		{
			throw new NotImplementedException ();
		}

		public string GetValue (ParamType paramType)
		{
			throw new NotImplementedException ();
		}

		public void SelectValue (ParamType paramType, string value)
		{
			throw new NotImplementedException ();
		}

		public bool IsSelected (ParamType paramType)
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

