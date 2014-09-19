using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace nilnul.collection.set.op
{
	/// <summary>
	/// the set of all subsets of the given set.
	/// </summary>
	public class Pow
	{
		public static IEnumerable<Set<T>> Enum<T>(
			Set<T> set_2bChanged
			
			) {

				if (set_2bChanged.Count() == 0)
				{
					yield return (new Set<T>());

				}
				else
				{
					
					var firstElement=set_2bChanged.ElementAt(0);
					set_2bChanged.Remove(firstElement);

					foreach (var item in Enum(set_2bChanged))
					{
						yield return item;
						var newSet = new Set<T>();
						newSet.Add(firstElement);
						newSet.add(item);
						yield return newSet;

					}
				}


		
		}

		public static Set<Set<T>> Eval<T>
			(
				Set<T> set
			) {
				var r = new Set<Set<T>>(
					new Set<T>.Eq()
				);

				var newSet = new Set<T>(set);


				foreach (var item in Enum(newSet))
				{
					r.Add(item);
					
				}

				return r;
		

		}

	}
}
