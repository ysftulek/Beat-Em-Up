using UnityEngine;

namespace __Game
{
	public class PlayerManager
	{
		static PlayerManager instance;
		
		public static PlayerManager Instance
		{
			get
			{
				if (instance == null)
				{
					instance = new PlayerManager();
				}
				return instance;
			}
			set => instance = value;
		}

		public Health PlayerHealth { get; set; }
	}
}
