using UnityEngine;

namespace __Game.FSM
{
	class WanderingState : State
	{
		Vector2 _targetPosition;
		Mover _mover;
		TargetFinder _targetFinder;

		public WanderingState(StateMachine stateMachine, GameObject character) : base(stateMachine, character) { }
		
		public override void Enter()
		{
			float rndX = Random.Range(-7f, 7f);
			float rndY = Random.Range(-4f, 4f);

			_targetPosition = new Vector2(rndX, rndY);
			_mover = Character.GetComponent<Mover>();
			_targetFinder = Character.GetComponent<TargetFinder>();
		}
		
		public override void Exit()
		{
			_targetPosition = Vector2.zero;
		}
		
		public override void Update()
		{
			Vector3 targetVector = (Vector3)_targetPosition - Character.transform.position;
			Vector3 targetDirection = targetVector.normalized;
			_mover.Move(targetDirection);

			if (targetVector.magnitude <= 0.1f)
			{
				StateMachine.SetState(StateMachine.IdleState);
				Debugger.Log("switching to idle");
			}

			if (_targetFinder.TryGetChasingTarget())
			{
				StateMachine.SetState(StateMachine.ChasingState);
			}
		}
	}
}
