using UnityEngine;

namespace __Game.FSM
{
	public class DeathState : State
	{
		public DeathState(StateMachine stateMachine, GameObject character) : base(stateMachine, character) { }
		
		public override void Enter()
		{
			Character.GetComponent<TargetFinder>().enabled = false;
		}
		
		public override void Exit()
		{
			
		}
		
		public override void Update()
		{
			
		}
	}
}
