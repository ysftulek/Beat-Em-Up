using UnityEngine;

namespace __Game.Loots
{
	[CreateAssetMenu]
	public class LootItem : ScriptableObject
	{
		[SerializeField] Sprite _itemSprite;
		[SerializeField] Collectable _prefab;

		public Collectable Prefab => _prefab;
	}
}
