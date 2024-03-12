using UnityEngine;
using UnityEngine.UI;

namespace __Game
{
	public class HealthBar : MonoBehaviour
	{
		[SerializeField] Slider _slider;
		
		Health _health;

		void Start()
		{
			_health = PlayerManager.Instance.PlayerHealth;
		}

		void Update()
		{
			_slider.value = _health.HealthPercentage;
		}
	}
}
