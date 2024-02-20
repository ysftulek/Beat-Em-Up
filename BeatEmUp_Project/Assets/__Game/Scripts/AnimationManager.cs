using System;
using System.Collections;
using UnityEngine;

namespace __Game
{
	public class AnimationManager : MonoBehaviour
	{
		[SerializeField] Animator _animator;

		Vector3 _lastPosition;

		void Awake()
		{
			_lastPosition = transform.position;
		}

		void Update()
		{
			Vector3 deltaPosition = transform.position - _lastPosition;
			
			_animator.SetFloat("Movement", deltaPosition.magnitude);

			_lastPosition = transform.position;
		}

		public void PlayDying()
		{
			_animator.SetTrigger("Dying");
		}
	}
}
