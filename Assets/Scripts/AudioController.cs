using UnityEngine;
using System.Collections;

public class AudioController : MonoBehaviour {

    public AudioClip clipStem01;
    public AudioClip clipStem02;
    public AudioClip clipStem03;
    public AudioClip clipStem04;
    public AudioClip clipStem05;
    public AudioClip clipStem06;
    public AudioClip clipStem07;
    public AudioClip clipStem08;
    public AudioClip clipStem09;
    public AudioClip clipBGM;

    private AudioSource audioStem01;
    private AudioSource audioStem02;
    private AudioSource audioStem03;
    private AudioSource audioStem04;
    private AudioSource audioStem05;
    private AudioSource audioStem06;
    private AudioSource audioStem07;
    private AudioSource audioStem08;
    private AudioSource audioStem09;
    private AudioSource audioBGM;

    int playCount = 0;

    public AudioSource AddAudio(AudioClip clip, bool loop, bool playAwake, float vol)
    {
        AudioSource audio = gameObject.AddComponent<AudioSource>();
        audio.clip = clip;
        audio.loop = loop;
        audio.playOnAwake = playAwake;
        audio.volume = vol;
        return audio;
    }

    public void Awake()
    {
        audioStem01 = AddAudio(clipStem01, true, false, .6f);
        audioStem02 = AddAudio(clipStem02, true, false, 1f);
        audioStem03 = AddAudio(clipStem03, true, false, 1f);
        audioStem04 = AddAudio(clipStem04, true, false, 1f);
        audioStem05 = AddAudio(clipStem05, true, false, 1f);
        audioStem06 = AddAudio(clipStem06, true, false, 1f);
        audioStem07 = AddAudio(clipStem07, true, false, 1f);
        audioStem08 = AddAudio(clipStem08, true, false, 1f);
        audioStem09 = AddAudio(clipStem09, true, false, 1f);
        audioBGM = AddAudio(clipBGM, true, true, .8f);
    }

    public void PlayNext()
    {
        playCount++;
        switch (playCount)
        {
            case 1:
                audioStem01.Play();
                break;
            case 2:
                audioStem02.Play();
                break;
            case 3:
                audioStem03.Play();
                break;
            case 4:
                audioStem04.Play();
                break;
            case 5:
                audioStem05.Play();
                break;
            case 6:
                audioStem06.Play();
                break;
            case 7:
                audioStem07.Play();
                break;
            case 8:
                audioStem08.Play();
                break;
            case 9:
                audioStem09.Play();
                break;
        }
    }

    void Update()
    {
        audioStem02.timeSamples = audioStem01.timeSamples;
        audioStem03.timeSamples = audioStem01.timeSamples;
        audioStem04.timeSamples = audioStem01.timeSamples;
        audioStem05.timeSamples = audioStem01.timeSamples;
        audioStem06.timeSamples = audioStem01.timeSamples;
        audioStem07.timeSamples = audioStem01.timeSamples;
        audioStem08.timeSamples = audioStem01.timeSamples;
        audioStem09.timeSamples = audioStem01.timeSamples;
    }
}
