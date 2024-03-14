using System;

namespace __Game
{
	public static class FightManager
	{
		public static event Action<int> FightStarting;
		
		public static void StartFight(int stageIndex)
		{
			FightStarting?.Invoke(stageIndex);
		}
	}
}
