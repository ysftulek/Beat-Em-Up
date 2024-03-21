using System;
using UnityEngine;

namespace __Game
{
	public class EnemySpawner : MonoBehaviour
	{
		[SerializeField] EnemySpawnConfig _enemySpawnConfig;

		public event Action<GameObject[]> EnemiesSpawned;
		
		void OnEnable()
		{
			FightManager.FightStarting += FightManager_FightStarting;
		}
		
		void OnDisable()
		{
			FightManager.FightStarting -= FightManager_FightStarting;
		}
		
		void FightManager_FightStarting(int stage)
		{
			Spawn(stage);
		}

		void Spawn(int stage)
		{
			GameObject[] enemies = _enemySpawnConfig.EnemiesByStage[stage].Enemies;
			GameObject[] result = new GameObject[enemies.Length];
			for (int i = 0; i < enemies.Length; i++)
			{
				result[i] = Instantiate(enemies[i], transform);
			}
			EnemiesSpawned?.Invoke(result);
		}
	}
}
