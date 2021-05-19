#if NETSTANDARD2_0_OR_GREATER || NET6_0_OR_GREATER || NETSTANDARD2_0
using System;
using System.Collections.Generic;
using System.Text;

namespace Microsoft.Maui.Controls.Compatibility
{
	public class Forms
	{
		public static void Init(IActivationState activationState)
		{
			throw new NotImplementedException();
		}
	}
}
#endif
