using System;
using UnityEngine;
using UnityEngine.Events;

namespace __Game.Loots
{
	public class Collectable : MonoBehaviour
	{
		[SerializeField] UnityEvent<GameObject> _onCollected;

		public event Action<Collectable> Collected;

		public void Collect(GameObject collector)
		{
			_onCollected.Invoke(collector);
			Collected?.Invoke(this);
		}
	}
}
