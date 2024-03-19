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

		void Update()
		{
			Vector3 deltaPos = transform.position - _lastPosition;
			if (deltaPos.x > 0.00001f)
			{
				_spriteRenderer.flipX = true;
			}
			else if (deltaPos.x < -0.00001f)
			{
				_spriteRenderer.flipX = false;
			}

			_lastPosition = transform.position;
		}
	}
}
