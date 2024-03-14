using System;
using UnityEngine;

namespace __Game
{
	public class CharacterMover : MonoBehaviour
	{
		[SerializeField] Rigidbody2D _rigidbody2D;
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
		}

		void FixedUpdate()
		{
			_moveVector.Normalize();
			Vector2 result = new Vector2(_moveVector.x, _moveVector.y) * (_moveSpeed * Time.deltaTime);
			_rigidbody2D.MovePosition(_rigidbody2D.position + result);	
		}
	}
}
