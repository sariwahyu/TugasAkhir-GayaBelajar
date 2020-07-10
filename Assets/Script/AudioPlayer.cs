using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class AudioPlayer : MonoBehaviour
{
    public static int audioNow = 0;
    public AudioSource audioSource;
    public AudioClip[] clipNames;
    public Text audioName;
    public Slider audioLenght;
    public static float audioValue;
    public static float audioMax;
    public static bool audioStatus = true;
    
    public static int clipMax;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        audioValue = audioLenght.value;
        audioMax = audioLenght.maxValue;
        clipMax = clipNames.Length;

        audioLenght.maxValue = clipNames[audioNow].length;
        audioLenght.value = audioSource.time;

        if (audioValue == audioLenght.maxValue && audioNow == clipNames.Length-1)
        {
            StopAudio();
        }
        else if (audioLenght.value == audioLenght.maxValue && audioNow < clipNames.Length - 1)
        {
            audioNow++;
            StartAudio(audioNow);
        }
        

    }

    public void StartAudio(int changeAudio)
    {
        audioNow = changeAudio;
        audioStatus = true;
        audioSource.clip = clipNames[audioNow];
        audioName.text = audioSource.clip.name;
        audioLenght.maxValue = audioSource.clip.length;
        audioLenght.value = 0;
        audioSource.Play();

    }

    public void NextAudio()
    {
        if (audioNow == clipNames.Length-1)
        {
            audioNow = 0;
        }
        else audioNow++;
        audioSource.clip = clipNames[audioNow];
        StartAudio(audioNow);

    }

    public void PrevAudio()
    {
        if (audioNow == 0)
        {
            audioNow = clipNames.Length - 1;
        }
        else audioNow--;
        audioSource.clip = clipNames[audioNow];
        StartAudio(audioNow);

    }

    public void PauseAudio()
    {
        audioSource.Pause();
        audioStatus = false;
    }

    public void StopAudio()
    {
        audioSource.Stop(); 
        audioStatus= false;
    }
}
