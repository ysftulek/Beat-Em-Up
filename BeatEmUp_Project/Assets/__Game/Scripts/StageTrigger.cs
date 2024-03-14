using UnityEngine;

namespace __Game
{
	public class StageTrigger : MonoBehaviour
	{
		[SerializeField] int _stageIndex;
		
		void OnTriggerEnter2D(Collider2D col)
		{
			if (col.TryGetComponent(out CharacterMover characterMover))
			{
				FightManager.StartFight(_stageIndex);
			}
		}
	}
}
