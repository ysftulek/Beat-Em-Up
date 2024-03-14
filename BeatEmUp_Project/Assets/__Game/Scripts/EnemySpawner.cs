using System;
using UnityEngine;

namespace __Game
{
	public class EnemySpawner : MonoBehaviour
	{
		void OnEnable()
		{
			FightManager.FightStarting += FightManager_FightStarting;
		}
		
		void OnDisable()
		{
			FightManager.FightStarting -= FightManager_FightStarting;
		}
		
		void FightManager_FightStarting(int obj)
		{
			Spawn(obj);
		}

		void Spawn(int stage)
		{
			// TODO: Instantiate enemy
		}
	}
}
