using nilnul.collection.set;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.set
{
	/// <summary>
	/// type if already defined in a dag, so here is paradox free.
	/// </summary>
	/// <typeparam name="T"></typeparam>
	public partial interface SetI<T>
		:SetI
	{
		bool contains(T a);

	}
}
