using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisonSoundTest : MonoBehaviour
{
    public int index;
    public GameObject audioManager;
    

    


    private void OnCollisionEnter(Collision collision)
    {
        string audioName = audioManager.GetComponent<BrAudioManager>().GetAudio(index);
        audioManager.GetComponent<BrAudioManager>().Play(audioName);
    
        //FindObjectOfType<BrAudioManager>().Play("do");
        

        Debug.Log("PlaySound");
    }
}