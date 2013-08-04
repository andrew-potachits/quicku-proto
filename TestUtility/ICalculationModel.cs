using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TestUtility
{
	public interface ICalculationModel
	{
		void Reset ();

		bool HasMultipleValues (ParamType paramType);
		string GetText(ParamType paramType);
	}

	public enum ParamType
	{
	}
}

