using System;
using UnityEngine;

namespace __Game
{
	[RequireComponent(typeof(Health))]
	public class HealthListener : MonoBehaviour
	{
		[Header("Dependencies")]
		[SerializeField] Health _health;
		[SerializeField] Collider2D _collider2D;
		[SerializeField] CharacterMover _characterMover;
		
		[Header("Settings")]
		[SerializeField] bool _disableColliderOnDeath;
		[SerializeField] bool _disableCharacterControllerOnDeath;

		void OnEnable()
		{
			_health.Dying += Health_Dying;
		}
		
		void OnDisable()
		{
			_health.Dying -= Health_Dying;
		}
		
		void Health_Dying()
		{
			if (_disableColliderOnDeath)
			{
				_collider2D.enabled = false;
			}

			if (_disableCharacterControllerOnDeath)
			{
				_characterMover.enabled = false;
			}
		}

		void Reset()
		{
			_health = GetComponent<Health>();
			_collider2D = GetComponent<Collider2D>();
			_characterMover = GetComponent<CharacterMover>();
		}
	}
}
