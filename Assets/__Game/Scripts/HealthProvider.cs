using UnityEngine;

namespace __Game
{
	public class HealthProvider : MonoBehaviour
	{
		[SerializeField] int _healthAmount = 10;

		public void Provide(GameObject player)
		{
			if (_healthAmount > 0)
			{
				player.GetComponent<Health>().Heal(_healthAmount);
			}
			else
			{
				player.GetComponent<Health>().TakeDamage(Mathf.Abs(_healthAmount));
			}
		}
	}
}
