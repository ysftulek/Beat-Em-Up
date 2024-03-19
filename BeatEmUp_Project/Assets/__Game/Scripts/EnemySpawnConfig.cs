using System;
using UnityEngine;

namespace __Game
{
	[CreateAssetMenu(menuName = "EnemySpawnConfig", fileName = "EnemySpawnConfig", order = 0)]
	public class EnemySpawnConfig : ScriptableObject
	{
		[SerializeField] EnemiesByStage[] _enemiesByStage;

		public EnemiesByStage[] EnemiesByStage => _enemiesByStage;
	}

	[Serializable]
	public struct EnemiesByStage
	{
		public GameObject[] Enemies;
	}
}
