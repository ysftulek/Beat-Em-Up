using UnityEngine;

namespace __Game
{
	public class CharacterMover : MonoBehaviour
	{
		[SerializeField] float _moveSpeed = 2f;
		
		Vector2 _moveVector;
		
		void Update()
		{
			_moveVector = Vector2.zero;
			
			if (Input.GetKey(KeyCode.W))
			{
				_moveVector.y = 1f;
			}
			else if (Input.GetKey(KeyCode.S))
			{
				_moveVector.y = -1f;
			}
			
			if (Input.GetKey(KeyCode.A))
			{
				_moveVector.x = -1f;
			}
			else if (Input.GetKey(KeyCode.D))
			{
				_moveVector.x = 1f;
			}
			
			
			_moveVector.Normalize();
			Vector3 result = new Vector3(_moveVector.x, _moveVector.y, 0f) * (_moveSpeed * Time.deltaTime);
			transform.position += result;
		}
	}
}
