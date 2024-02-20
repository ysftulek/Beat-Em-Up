using UnityEngine;

namespace __Game
{
	// menzil, menzil içindeki hasar verilebilir hedefleri bul, bunlara saldırı gücün kadar hasar ver
	public class AttackController : MonoBehaviour
	{
		[SerializeField] LayerMask _damageableLayerMask;
		[SerializeField] int _attackPoint = 20;
		[SerializeField] float _radius = 1f;
		
		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				Collider2D[] results = Physics2D.OverlapCircleAll(transform.position, _radius, _damageableLayerMask);
				foreach (Collider2D result in results)
				{
					if (result.TryGetComponent(out Health health))
					{
						health.TakeDamage(_attackPoint);
					}
				}
			}
		}
	}
}
