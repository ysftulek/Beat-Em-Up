using UnityEngine;

namespace __Game
{
	public class AnimationManager : MonoBehaviour
	{
		[SerializeField] Animator _animator;

		Rigidbody2D _rb2d;
		Vector2 _lastPosition;
		
		static readonly int Movement = Animator.StringToHash("Movement");
		static readonly int Dying = Animator.StringToHash("Dying");

		void Awake()
		{
			_lastPosition = transform.position;
			_rb2d = GetComponent<Rigidbody2D>();
		}

		void Update()
		{
			Vector2 deltaPosition = (Vector2)transform.position - _lastPosition;
			
			_animator.SetFloat(Movement, deltaPosition.magnitude);

			_lastPosition = (Vector2)transform.position;
		}

		public void PlayDying()
		{
			_animator.SetTrigger(Dying);
		}
	}
}
