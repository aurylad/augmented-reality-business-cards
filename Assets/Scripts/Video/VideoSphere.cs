using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoSphere : MonoBehaviour {

	public RawImage image;

	private VideoPlayer videoPlayer;
	private VideoSource videoSource;
	private AudioSource audioSource;
	private int count = 0;
	private int count2 = 0;
	public GameObject truck;


	void Start () {
		image.enabled = false;
	}


	private void OnMouseOver(){
		if (Input.GetMouseButtonDown(0)){
			if (count == 0) {
				image.enabled = true;
				Application.runInBackground = true;
				StartCoroutine (playVideo ());
				truck.SetActive (false);
				count++;
			} else {
				truck.SetActive (true);
				image.enabled = false;
				count = 0;
			}
		}
	}
		

	IEnumerator playVideo() {
		if (count2 == 0) {
			//Add VideoPlayer to the GameObject
			videoPlayer = image.gameObject.AddComponent<VideoPlayer> ();

			//Add AudioSource
			audioSource = image.gameObject.AddComponent<AudioSource> ();
			count2++;
		} 
		//Disable Play on Awake for both Video and Audio
		videoPlayer.playOnAwake = false;
		audioSource.playOnAwake = false;
		audioSource.Pause();

		//We want to play from video clip not from url

		videoPlayer.source = VideoSource.VideoClip;

		// Vide clip from Url
		videoPlayer.source = VideoSource.Url;
		videoPlayer.url = "https://challangesnap.000webhostapp.com/images/house.mp4";


		//Set Audio Output to AudioSource
		videoPlayer.audioOutputMode = VideoAudioOutputMode.AudioSource;

		//Assign the Audio from Video to AudioSource to be played
		videoPlayer.EnableAudioTrack(0, true);
		videoPlayer.SetTargetAudioSource(0, audioSource);

		//Set video To Play then prepare Audio to prevent Buffering
		//videoPlayer.clip = videoToPlay;
		videoPlayer.Prepare();

		//Wait until video is prepared
		while (!videoPlayer.isPrepared)
		{
			yield return null;
		}

		//Debug.Log("Done Preparing Video");

		//Assign the Texture from Video to RawImage to be displayed
		image.texture = videoPlayer.texture;

		//Play Video
		videoPlayer.Play();


		//Play Sound
		audioSource.Play();

		//Debug.Log("Playing Video");
		while (videoPlayer.isPlaying)
		{
			Debug.LogWarning("Video Time: " + Mathf.FloorToInt((float)videoPlayer.time));
			yield return null;
		}

		//Debug.Log("Done Playing Video");
	}
		
}
