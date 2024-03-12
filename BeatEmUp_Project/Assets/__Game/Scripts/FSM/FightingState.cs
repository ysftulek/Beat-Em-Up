using UnityEngine;

namespace __Game.FSM
{
	class FightingState : State
	{
		TargetFinder _targetFinder;
		float _attackTimer;
		
		public FightingState(StateMachine stateMachine, GameObject character) : base(stateMachine, character) { }
		public override void Enter()
		{
			_targetFinder = Character.GetComponent<TargetFinder>();
			Debugger.Log("Switching to fighting state");
		}
		public override void Exit()
		{
			
		}
		public override void Update()
		{
			_attackTimer += Time.deltaTime;

			if (_targetFinder.TryGetFightingTarget())
			{
				if (_attackTimer >= 1f)
				{
					Debugger.Log("attacking");
					_targetFinder.FightingTarget.GetComponent<Health>().TakeDamage(10);
					_attackTimer -= 1f;
				}
			}
			else if (_targetFinder.TryGetChasingTarget())
			{
				StateMachine.SetState(StateMachine.ChasingState);
			}
		}
	}
}
