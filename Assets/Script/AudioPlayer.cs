using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioPlayer : MonoBehaviour
{
    int audioNow= 0;
    AudioSource audioSource;
    public AudioClip[] clipNames;
    public Text audioName;
    public Slider audioLenght;
    private bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        StartAudio();
    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            audioLenght.value += Time.deltaTime;
            if(audioLenght.value >= audioSource.clip.length)
            {
                audioNow++;
                if(audioNow >= clipNames.Length)
                {
                    audioNow = 0;
                }
                StartAudio();
            }
        }
    }

    public void StartAudio(int changeAudio = 0)
    {
        audioNow += changeAudio;
        if (audioNow >= clipNames.Length)
        {
            audioNow = 0;
        }
        else if (audioNow < 0)
        {
            audioNow = clipNames.Length - 1;
        }
        if(audioSource.isPlaying && changeAudio == 0)
        {
            return;
        }
        if(stop)
        {
            stop = false;
        }
        audioSource.clip = clipNames[audioNow];
        audioName.text = audioSource.clip.name;
        audioLenght.maxValue = audioSource.clip.length;
        audioLenght.value = 0;
        audioSource.Play();
    }

    public void StopAudio()
    {
        audioSource.Stop();
        stop = true;
    }
}
