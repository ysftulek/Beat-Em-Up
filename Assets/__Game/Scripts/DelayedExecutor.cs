using UnityEngine;
using UnityEngine.Events;

namespace __Game
{
	public class DelayedExecutor : MonoBehaviour
	{
		[SerializeField] float _delayTime;
		[SerializeField] UnityEvent _completed;

		public void Run()
		{
			Invoke(nameof(OnComplete), _delayTime);
		}

		void OnComplete()
		{
			_completed.Invoke();
		}
	}
}
