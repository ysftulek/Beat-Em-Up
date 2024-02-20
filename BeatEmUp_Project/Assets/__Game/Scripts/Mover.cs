using UnityEngine;

namespace __Game
{
	public class Mover : MonoBehaviour
	{
		[SerializeField] float _moveSpeed;

		public void Move(Vector2 normalizedDirection)
		{
			transform.position += (Vector3)normalizedDirection * (Time.deltaTime * _moveSpeed);
		}
	}
}
