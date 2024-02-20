using System.Collections.Generic;
using UnityEngine;

namespace __Game.Loots
{
	[CreateAssetMenu]
	public class LootManager : ScriptableObject
	{
		List<Collectable> _activeLoots = new List<Collectable>();
		
		public void InstantiateLoot(LootConfiguration lootConfiguration, Vector3 worldPosition)
		{
			float randomValue = Random.Range(0f, 1f);
			if (randomValue <= lootConfiguration.DropChance)
			{
				foreach (LootItem item in lootConfiguration.LootItems)
				{
					Collectable collectable = Instantiate(item.Prefab, worldPosition, Quaternion.identity);
					collectable.Collected += Collectable_Collected;
					_activeLoots.Add(collectable);
				}
			}
		}
		
		void Collectable_Collected(Collectable collectable)
		{
			_activeLoots.Remove(collectable);
		}
	}
}
