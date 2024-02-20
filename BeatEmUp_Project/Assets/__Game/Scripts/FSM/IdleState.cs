using UnityEngine;

namespace __Game.FSM
{
	class IdleState : State
	{
		public IdleState(StateMachine stateMachine, GameObject character) : base(stateMachine, character) { }

		float _timer;
		float _wanderingInterval;

		public override void Enter()
		{
			// Idle animasyonu oynat
			_timer = 0f;
			_wanderingInterval = Random.Range(2f, 3f);
			Debug.Log("waiting for: " + _wanderingInterval);

			// Character.GetComponent<AnimationManager>().PlayIdle();
		}

		public override void Exit()
		{
		}

		public override void Update()
		{
			_timer += Time.deltaTime;

			if (_timer >= _wanderingInterval)
			{
				StateMachine.SetState(StateMachine.WanderingState);
				Debug.Log("switching to wandering");
			}
		}
	}
}
