using System;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Timeline;

namespace __Game
{
	public class EnemyDirector : MonoBehaviour
	{
		[SerializeField] PlayableDirector _playableDirector;
		[SerializeField] EnemySpawner _enemySpawner;
		
		public List<Animator> trackList = new List<Animator>();
		public TimelineAsset timelineAsset;

		void OnEnable()
		{
			_enemySpawner.EnemiesSpawned += EnemySpawner_EnemiesSpawned;
		}
		
		void OnDisable()
		{
			_enemySpawner.EnemiesSpawned -= EnemySpawner_EnemiesSpawned;
		}
		
		void EnemySpawner_EnemiesSpawned(GameObject[] obj)
		{
			// TODO: bind enemies into the director and play the timeline via director
			List<Animator> a = new List<Animator>();
			foreach (GameObject o in obj)
			{
				a.Add(o.AddComponent<Animator>());
			}
			trackList = a;
			BindTimelineTracks();
			_playableDirector.Play();
		}

		void BindTimelineTracks()
		{
			Debug.Log("Binding Timeline Tracks!");
			timelineAsset = (TimelineAsset)_playableDirector.playableAsset;
			// iterate through tracks and map the objects appropriately
			for( var i = 0; i < trackList.Count; i ++)
			{
				if( trackList[i] != null)
				{
					TrackAsset track = timelineAsset.GetOutputTrack(i);
					_playableDirector.SetGenericBinding(track, trackList[i]);
				}
			}
		}
	}
}
