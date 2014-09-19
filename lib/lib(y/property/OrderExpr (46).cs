using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.properties
{
	public class OrderExpr : OrderExpr_I
	{
		private Set_I _set;
		public OrderExpr(Set_I set)
		{
			this._set=set;
		}
	}
}
