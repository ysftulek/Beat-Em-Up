using UnityEngine;

namespace __Game.FSM
{
	class ChasingState : State
	{
		TargetFinder _targetFinder;
		
		public ChasingState(StateMachine stateMachine, GameObject character) : base(stateMachine, character) { }
		public override void Enter()
		{
			_targetFinder = Character.GetComponent<TargetFinder>();
			_targetFinder.enabled = true;
			Debug.Log("starting to chase");
			Debug.Log("Target: " + _targetFinder.ChasingTarget);
		}
		
		public override void Exit()
		{
			_targetFinder.enabled = false;
			Debug.Log("exiting from chase");
		}
		
		public override void Update()
		{
			if (_targetFinder.TryGetFightingTarget())
			{
				StateMachine.SetState(StateMachine.FightingState);
			}
		}
	}
}
