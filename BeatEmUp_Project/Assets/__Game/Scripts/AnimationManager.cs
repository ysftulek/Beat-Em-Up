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
			// 0.3532e-05 = 0.00003532
			if (deltaPosition.x is < 0.001f and > -0.001f)
			{
				deltaPosition.x = 0f;
			}
			if (deltaPosition.y is < 0.001f and > -0.001f)
			{
				deltaPosition.y = 0f;
			}
			_animator.SetFloat(Movement, deltaPosition.magnitude * 100f);
			_lastPosition = (Vector2)transform.position;
		}

		public void PlayDying()
		{
			_animator.SetTrigger(Dying);
		}
	}
}
