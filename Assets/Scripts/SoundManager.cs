using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static SoundManager instance;
    public static int i = 1;

    public AudioSource currentNote;

    public AudioClip[] audioSources;

    public void Awake()
    {
        instance = this;
        //currentNote = GetComponent<AudioSource>();
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void PlayBach()
    {
        currentNote.clip = audioSources[i];
        currentNote.Play();
        i++;
        if (i == 15) { 
            
        currentNote.clip = audioSources[i];
        currentNote.Play();
    }

    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
