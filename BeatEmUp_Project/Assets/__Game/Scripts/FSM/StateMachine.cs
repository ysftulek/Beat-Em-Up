using UnityEngine;

namespace __Game.FSM
{
	public class StateMachine : MonoBehaviour
	{
		[SerializeField] GameObject _character;
		
		State _currentState;
		
		public State IdleState { get; private set; }
		public State WanderingState { get; private set; }
		public State ChasingState { get; private set; }
		public State FightingState { get; private set; }
		public State DeathState { get; private set; }

		void Awake()
		{
			IdleState = new IdleState(this, _character);
			WanderingState = new WanderingState(this, _character);
			ChasingState = new ChasingState(this, _character);
			FightingState = new FightingState(this, _character);
			DeathState = new DeathState(this, _character);

			_currentState = IdleState;
		}
		
		void Update()
		{
			_currentState.Update();
		}

		public void SetState(State state)
		{
			_currentState.Exit();
			_currentState = state;
			_currentState.Enter();
		}

		public void SetDeathState()
		{
			SetState(DeathState);
		}
	}
}
