using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class SoundAnimation : MonoBehaviour
{ 
    [SerializeField] private AudioSource _source;

    private void Awake()
    {
        _source= GetComponent<AudioSource>();
    }

    public void PlaySound()
    {
        _source.Play();
    } 

}
