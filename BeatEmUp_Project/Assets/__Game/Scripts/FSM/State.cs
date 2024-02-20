using UnityEngine;

namespace __Game.FSM
{
	public abstract class State
	{
		protected StateMachine StateMachine;
		protected GameObject Character;
		
		public State(StateMachine stateMachine, GameObject character)
		{
			StateMachine = stateMachine;
			Character = character;
		}

		public abstract void Enter();
		public abstract void Exit();
		public abstract void Update();
	}
}
