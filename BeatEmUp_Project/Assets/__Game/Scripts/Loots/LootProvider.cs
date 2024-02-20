using UnityEngine;

namespace __Game.Loots
{
	public class LootProvider : MonoBehaviour
	{
		[SerializeField] LootManager _lootManager;
		[SerializeField] LootConfiguration _lootConfiguration;

		public void Provide()
		{
			_lootManager.InstantiateLoot(_lootConfiguration, transform.position);
		}
	}
}
