using System;
using UnityEngine;

namespace __Game
{
	public class FightColliderActivator : MonoBehaviour
	{
		[SerializeField] int _stage;
		[SerializeField] Collider2D[] _colliders;

		void OnValidate()
		{
			if (ComponentUtilities.TryGetComponentInParentAndChild(this, out StageTriggerArea result))
			{
				_stage = result.StageIndex;
			}
		}

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
			foreach (Collider2D collider1 in _colliders)
			{
				collider1.enabled = true;
			}
		}
	}
}
