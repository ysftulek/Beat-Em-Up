using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace __Game.FSM
{
	public static class Debugger
	{
		[Conditional("ENABLE_DEBUG")]
		public static void Log(object message)
		{
			Debug.Log(message);
		}
		
		[Conditional("ENABLE_DEBUG")]
		public static void Log(object message, Object context)
		{
			Debug.Log(message, context);
		}
	}
}
