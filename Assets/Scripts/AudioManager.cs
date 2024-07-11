using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [Header("--------Audio Source-------")]
    [SerializeField] AudioSource musicSource;
    [SerializeField] AudioSource SFXSource;

    [Header("--------Audio Clip-------")]
    public AudioClip background;
    public AudioClip death;
    public AudioClip jump;

    public void Start()
    {
       musicSource.clip = background;
       musicSource.loop = true;
       musicSource.playOnAwake = true;
       musicSource.Play();
    }

    public void playSFX(AudioClip clip)
    {
        SFXSource.PlayOneShot(clip);
    }
}
