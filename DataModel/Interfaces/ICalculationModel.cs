using System;
using System.Collections.Generic;

namespace DataModel.Interfaces
{
	public interface ICalculationModel
	{
		void Reset ();
		void Calculate();

		IEnumerable<ParamType> GetUnselected ();

		bool HasMultipleValues (ParamType paramType);
		string GetValue(ParamType paramType);
		void SelectValue (ParamType paramType, string value);
		bool IsSelected(ParamType paramType);


	}

	public enum ParamType
	{
		Series,
		FrameDepth,
		Configuration,
		IGUType,
		IGUCoating,
		IGUMakeup,
		Width,
		Height
	}
}

