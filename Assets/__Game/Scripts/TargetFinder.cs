using System;
using UnityEngine;

namespace __Game
{
	public class TargetFinder : MonoBehaviour
	{
		[SerializeField] Mover _mover;
		[SerializeField] LayerMask _targetLayerMask;
		[SerializeField] float _chasingRadius;
		[SerializeField] float _fightingRadius;

		GameObject _chasingTarget;
		GameObject _fightingTarget;

		public GameObject FightingTarget => _chasingTarget;
		public GameObject ChasingTarget => _chasingTarget;

		void Update()
		{
			if (_chasingTarget)
			{
				Vector3 dir = _chasingTarget.transform.position - transform.position; 
				_mover.Move(dir.normalized);
			}
		}

		public Collider2D TryGetChasingTarget()
		{
			Collider2D coll2D = Physics2D.OverlapCircle(transform.position, _chasingRadius, _targetLayerMask);
			if (coll2D)
			{
				_chasingTarget = coll2D.gameObject;
			}
			else
			{
				_chasingTarget = null;
			}
			return coll2D;
		}
		
		public Collider2D TryGetFightingTarget()
		{
			Collider2D coll2D = Physics2D.OverlapCircle(transform.position, _fightingRadius, _targetLayerMask);
			if (coll2D)
			{
				_fightingTarget = coll2D.gameObject;
			}
			else
			{
				_fightingTarget = null;
			}
			return coll2D;
		}
	}
}
