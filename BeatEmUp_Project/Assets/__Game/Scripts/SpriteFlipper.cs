using UnityEngine;

namespace __Game
{
	public class SpriteFlipper : MonoBehaviour
	{
		[SerializeField] SpriteRenderer _spriteRenderer;
		Vector3 _lastPosition;

		void Awake()
		{
			_lastPosition = transform.position;
		}

		void FixedUpdate()
		{
			Vector3 deltaPos = transform.position - _lastPosition;
			if (deltaPos.x > 0)
			{
				_spriteRenderer.flipX = true;
			}
			else if (deltaPos.x < 0)
			{
				_spriteRenderer.flipX = false;
			}

			_lastPosition = transform.position;
		}
	}
}
