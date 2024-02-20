using UnityEngine;

namespace __Game.Loots
{
	public class Collector : MonoBehaviour
	{
		[SerializeField] LayerMask _collectLayerMask;
		[SerializeField] float _radius = 1f;
		
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Collider2D[] results = Physics2D.OverlapCircleAll(transform.position, _radius, _collectLayerMask);
				foreach (Collider2D result in results)
				{
					if (result.TryGetComponent(out Collectable collectable))
					{
						collectable.Collect(gameObject);
					}
				}
			}
		}
	}
}
