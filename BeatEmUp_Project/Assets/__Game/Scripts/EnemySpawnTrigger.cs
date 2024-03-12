using System;
using UnityEngine;

namespace __Game
{
	public class EnemySpawnTrigger : MonoBehaviour
	{
		[SerializeField] int _stage;
		[SerializeField] EnemySpawner _enemySpawner;
		[SerializeField] Camera _camera;

		void OnTriggerEnter(Collider other)
		{
			if (other.TryGetComponent(out CharacterMover characterMover))
			{
				_enemySpawner.Spawn(_stage);
			}
		}
	}
}
