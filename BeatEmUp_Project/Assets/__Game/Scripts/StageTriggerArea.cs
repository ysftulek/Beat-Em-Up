using UnityEngine;

namespace __Game
{
	[RequireComponent(typeof(Collider2D))]
	public class StageTriggerArea : MonoBehaviour
	{
		[SerializeField] int _stageIndex;

		public int StageIndex => _stageIndex;
		
		void OnTriggerEnter2D(Collider2D col)
		{
			if (col.TryGetComponent(out CharacterMover _))
			{
				FightManager.StartFight(_stageIndex);
				GetComponent<Collider2D>().enabled = false;
			}
		}
	}
}
