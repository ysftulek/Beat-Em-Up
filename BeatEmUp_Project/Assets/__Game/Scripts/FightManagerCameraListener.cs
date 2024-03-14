using System;
using UnityEngine;

namespace __Game
{
	public class FightManagerCameraListener : MonoBehaviour
	{
		[SerializeField] CameraManager _cameraManager;
		
		void OnEnable()
		{
			FightManager.FightStarting += FightManager_FightStarting;
		}

		void OnDisable()
		{
			FightManager.FightStarting -= FightManager_FightStarting;
		}

		void FightManager_FightStarting(int obj)
		{
			_cameraManager.EnableStageVirtualCamera(obj);
		}
	}
}
