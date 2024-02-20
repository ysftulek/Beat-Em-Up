using System;
using UnityEngine;
using UnityEngine.Events;

namespace __Game
{
	public class Health : MonoBehaviour
	{
		[SerializeField] UnityEvent _dying;
		[SerializeField] UnityEvent _takingDamage;
		[SerializeField] UnityEvent _healing;
		[SerializeField] int _maxHealth;

		public event Action Dying;
		
		int _value;

		void Awake()
		{
			_value = _maxHealth;
		}

		public void TakeDamage(int amount)
		{
			_value -= amount;
			_takingDamage.Invoke();
			if (_value <= 0)
			{
				// vfx, sfx
				_dying.Invoke();
				Dying?.Invoke();
			}
		}

		public void Heal(int amount)
		{
			_value = Mathf.Clamp(_value + amount, 0, _maxHealth);
			// can artma vfx
			_healing.Invoke();
		}
	}
}
