using System;
using UnityEngine;
using UnityEngine.Playables;

namespace __Game
{
	public class EnemySpawner : MonoBehaviour
	{
		[SerializeField] EnemySpawnConfig _enemySpawnConfig;
		[SerializeField] PlayableDirector _playableDirector;
		
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
			for (int i = 0; i < _enemySpawnConfig.EnemiesByStage[stage].Enemies.Length; i++)
			{
				GameObject instantiated = Instantiate(_enemySpawnConfig.EnemiesByStage[stage].Enemies[i]);
			}
			//_playableDirector.SetGenericBinding();
		}
	}

}
