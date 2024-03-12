using UnityEngine;

namespace __Game
{
	public class PlayerHealthRegisterer : MonoBehaviour
	{
		[SerializeField] Health _playerHealth;

		void Awake()
		{
			if (_playerHealth == null)
			{
				Debug.LogError("Player Health shouldn't be empty!!!");
			}
			PlayerManager.Instance.PlayerHealth = _playerHealth;
		}
	}
}
