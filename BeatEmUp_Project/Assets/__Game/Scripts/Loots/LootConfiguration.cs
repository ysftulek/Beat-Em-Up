using System.Collections.Generic;
using UnityEngine;

namespace __Game.Loots
{
	[CreateAssetMenu]
	public class LootConfiguration : ScriptableObject
	{
		[SerializeField] List<LootItem> _lootItems;
		[SerializeField, Range(0f, 1f)] float _dropChance = 0.2f;
		
		public float DropChance => _dropChance;
		public List<LootItem> LootItems => _lootItems;
	}
}
