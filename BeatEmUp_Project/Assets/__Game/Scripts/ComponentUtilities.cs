using UnityEngine;

namespace __Game
{
	public static class ComponentUtilities
	{
		public static bool TryGetComponentInParentAndChild<T>(Component component, out T result)
		{
			T c = component.GetComponentInParent<T>();
			if (c != null)
			{
				result = c;
				return true;
			}
			c = component.GetComponentInChildren<T>();
			if (c != null)
			{
				result = c;
				return true;
			}
			c = component.GetComponent<T>();
			if (c != null)
			{
				result = c;
				return true;
			}
			
			result = c;
			return false;
		}
	}
}
