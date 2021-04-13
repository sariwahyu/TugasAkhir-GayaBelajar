using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioPlayerUI : MonoBehaviour
{
    public GameObject playlistPlay0;
    public GameObject playlistPlay1;
    public GameObject playlistPlay2;
    public GameObject playlistPlay3;

    public GameObject playlistPause0;
    public GameObject playlistPause1;
    public GameObject playlistPause2;
    public GameObject playlistPause3;

    void Start()
    {
        playlistPlay0.SetActive(true);
        playlistPlay1.SetActive(true);
        playlistPlay2.SetActive(true);
        playlistPlay3.SetActive(true);

        playlistPause0.SetActive(false);
        playlistPause1.SetActive(false);
        playlistPause2.SetActive(false);
        playlistPause3.SetActive(false);

    }

    void Update()
    {
        if (AudioPlayer.clipMax-1 == AudioPlayer.audioNow && AudioPlayer.audioValue == AudioPlayer.audioMax )
            PauseStopAudio();
        else if (AudioPlayer.audioValue != 0)
            StartAudio();
    }

    public void StartAudio()
    { 
        if (AudioPlayer.audioStatus == true)
        {
            if (AudioPlayer.audioNow == 0)
            {
                playlistPlay0.SetActive(false);
                playlistPlay1.SetActive(true);
                playlistPlay2.SetActive(true);
                playlistPlay3.SetActive(true);

                playlistPause0.SetActive(true);
                playlistPause1.SetActive(false);
                playlistPause2.SetActive(false);
                playlistPause3.SetActive(false);
            }
            else if (AudioPlayer.audioNow == 1)
            {
                playlistPlay0.SetActive(true);
                playlistPlay1.SetActive(false);
                playlistPlay2.SetActive(true);
                playlistPlay3.SetActive(true);

                playlistPause0.SetActive(false);
                playlistPause1.SetActive(true);
                playlistPause2.SetActive(false);
                playlistPause3.SetActive(false);
            }
            else if (AudioPlayer.audioNow == 2)
            {
                playlistPlay0.SetActive(true);
                playlistPlay1.SetActive(true);
                playlistPlay2.SetActive(false);
                playlistPlay3.SetActive(true);

                playlistPause0.SetActive(false);
                playlistPause1.SetActive(false);
                playlistPause2.SetActive(true);
                playlistPause3.SetActive(false);
            }
            else if (AudioPlayer.audioNow == 3)
            {
                playlistPlay0.SetActive(true);
                playlistPlay1.SetActive(true);
                playlistPlay2.SetActive(true);
                playlistPlay3.SetActive(false);

                playlistPause0.SetActive(false);
                playlistPause1.SetActive(false);
                playlistPause2.SetActive(false);
                playlistPause3.SetActive(true);
            }
        }
        

    }

    public void PauseStopAudio()
    {
        if(AudioPlayer.audioStatus == false)
        {
            playlistPlay0.SetActive(true);
            playlistPlay1.SetActive(true);
            playlistPlay2.SetActive(true);
            playlistPlay3.SetActive(true);

            playlistPause0.SetActive(false);
            playlistPause1.SetActive(false);
            playlistPause2.SetActive(false);
            playlistPause3.SetActive(false);
        }
        
    }
}
