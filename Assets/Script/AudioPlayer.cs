using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AudioPlayer : MonoBehaviour
{
    public int audioNow= 0;
    public AudioSource audioSource;
    public AudioClip[] clipNames;
    public Text audioName;
    public Slider audioLenght;
    public GameObject playButton;
    public GameObject pauseButton;
    private bool stop = true;

    // Start is called before the first frame update
    void Start()
    {
        playButton.SetActive(true);
        pauseButton.SetActive(false);
        audioSource = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
        if (!stop)
        {
            audioLenght.value += Time.deltaTime;
            if (audioLenght.value >= audioSource.clip.length)
            {
                audioNow++;
                if (audioNow >= clipNames.Length)
                {
                    StartAudio();

                }
            }
        }
    }

    public void StartAudio(int changeAudio = 0)
    {
        audioNow += changeAudio;
        playButton.SetActive (false);
        pauseButton.SetActive(true);

        if (audioNow >= clipNames.Length)
        {
            audioNow = 0;
        }
        else if (audioNow < 0)
        {
            audioNow = clipNames.Length - 1;
        }
        audioSource.clip = clipNames[audioNow];
        audioName.text = audioSource.clip.name;
        audioLenght.maxValue = audioSource.clip.length;
        audioLenght.value = 0;
        audioSource.Play();
    }

    public void PauseAudio()
    {
        audioSource.Pause();
        pauseButton.SetActive(false);
        playButton.SetActive(true);

    }
}
