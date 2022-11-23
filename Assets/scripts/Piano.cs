using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Piano : MonoBehaviour
{
    //This a dataType - defined by Unity
    //array of sounds
    public AudioClip[] audioClip;

    //Source of sounds
    private AudioSource audioSource;
    //get array for move in x,y,z - position,scale,rotate
    public Transform[] notesT;

    private void Start() {
        //add sound for play
        WhiteNotes.toneName += PlaySound;
        //get Audio Source component in Unity
        //when the game started, it gets all of sounds in 
        audioSource = GetComponent<AudioSource> ();


    }

    private void OnDestroy() {
        //mines sound after its plyed - like cash deleted - for better usage of RAM
        WhiteNotes.toneName -= PlaySound;
    }

    private void Update() {
        //when touch is finished
        if (Input.GetMouseButtonUp(0)) {
            //apply vector3
            for(int i = 0; i < notesT.Length; i++){
            notesT[i].localScale = new Vector3(2,1.41407f,1);
        }
        }
    }
    //playoneshot = play only once
    //play sounds
    //case inputes are sprite note names!!!!
    //name=notes name
    public void PlaySound(string name) {
        switch (name){
            case "whiteNote1":case "blackNote2":
            audioSource.PlayOneShot (audioClip[0]);
            notesT[0].localScale = pos();
            break;
            case "whiteNote2":case "blackNote3":
            audioSource.PlayOneShot (audioClip[1]);
            notesT[1].localScale = pos();
            break;
            case "whiteNote3":case "blackNote7":
            audioSource.PlayOneShot (audioClip[2]);
            notesT[2].localScale = pos();
            break;
            case "whiteNote4":case "blackNote8":
            audioSource.PlayOneShot (audioClip[3]);
            notesT[3].localScale = pos();
            break;
            case "whiteNote5":case "blackNote4":
            audioSource.PlayOneShot (audioClip[4]);
            notesT[4].localScale = pos();
            break;
            case "whiteNote6":case "blackNote5":case "blackNote9":
            audioSource.PlayOneShot (audioClip[5]);
            notesT[5].localScale = pos();
            break;
            case "whiteNote7":case "blackNote1":case "blackNote10":
            audioSource.PlayOneShot (audioClip[6]);
            notesT[6].localScale = pos();
            break;
            case "whiteNote8":case "blackNote6":
            audioSource.PlayOneShot (audioClip[7]);
            notesT[7].localScale = pos();
            break;
            case "whiteNote9":
            audioSource.PlayOneShot (audioClip[8]);
            notesT[8].localScale = pos();
            break;
            case "whiteNote10":
            audioSource.PlayOneShot (audioClip[9]);
            notesT[9].localScale = pos();
            break;
            case "whiteNote11":
            audioSource.PlayOneShot (audioClip[10]);
            notesT[10].localScale = pos();
            break;
            case "whiteNote12":
            audioSource.PlayOneShot (audioClip[11]);
            notesT[11].localScale = pos();
            break;
            case "whiteNote13":
            audioSource.PlayOneShot (audioClip[12]);
            notesT[12].localScale = pos();
            break;
            case "whiteNote14":
            audioSource.PlayOneShot (audioClip[13]);
            notesT[13].localScale = pos();
            break;
        }
    }
    //method for transform
    //vector3= 3D of the object that selected in app
    private Vector3 pos(){
        return new Vector3 (0.40f,0.40f,0.40f);
    }

}
