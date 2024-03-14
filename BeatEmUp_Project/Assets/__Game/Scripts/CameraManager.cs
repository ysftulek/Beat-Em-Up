using Cinemachine;
using UnityEngine;

namespace __Game
{
	public class CameraManager : MonoBehaviour
	{
		[SerializeField] CinemachineVirtualCamera[] _virtualStageCameras;

		public void EnableStageVirtualCamera(int stageIndex)
		{
			Debug.Log("sadasdas");
			_virtualStageCameras[stageIndex].enabled = true;
		}
	}
}
