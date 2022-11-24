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
    //for change note size when its clicked
    public Transform[] notesT;
    public Transform[] notesB;
    public Transform[] notesS;

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
            //these are original size of sprites
            for(int i = 0; i < notesT.Length; i++){
            notesT[i].localScale = new Vector3(2,1.41407f,1);
            }

            for(int j = 0; j < notesB.Length; j++){
            notesB[j].localScale = new Vector3(1.390703f,1.364084f,1.3376f);
            }
            for(int g = 0; g < notesS.Length; g++){
            notesS[g].localScale = new Vector3(1,1,1);
            }
        
        }
    }
    //playoneshot = play only once
    //play sounds
    //case inputes are sprite note names!!!!
    //name=notes name
    //pos is a vector3 method
    //notesX is sprites that we want them change size
    //localscale is size of sprits
    public void PlaySound(string name) {
        switch (name){
            case "whiteNote1":
            audioSource.PlayOneShot (audioClip[0]);
            notesT[0].localScale = pos();
            notesS[0].localScale = pos2();
            break;
            case "whiteNote2":
            audioSource.PlayOneShot (audioClip[1]);
            notesT[1].localScale = pos();
            notesS[1].localScale = pos2();
            break;
            case "whiteNote3":
            audioSource.PlayOneShot (audioClip[2]);
            notesT[2].localScale = pos();
            notesS[2].localScale = pos2();
            break;
            case "whiteNote4":
            audioSource.PlayOneShot (audioClip[3]);
            notesT[3].localScale = pos();
            notesS[3].localScale = pos2();
            break;
            case "whiteNote5":
            audioSource.PlayOneShot (audioClip[4]);
            notesT[4].localScale = pos();
            notesS[0].localScale = pos2();
            break;
            case "whiteNote6":
            audioSource.PlayOneShot (audioClip[5]);
            notesT[5].localScale = pos();
            notesS[1].localScale = pos2();
            break;
            case "whiteNote7":
            audioSource.PlayOneShot (audioClip[6]);
            notesT[6].localScale = pos();
            notesS[2].localScale = pos2();
            break;
            case "whiteNote8":
            audioSource.PlayOneShot (audioClip[7]);
            notesT[7].localScale = pos();
            notesS[3].localScale = pos2();
            break;
            case "whiteNote9":
            audioSource.PlayOneShot (audioClip[8]);
            notesT[8].localScale = pos();
            notesS[0].localScale = pos2();
            break;
            case "whiteNote10":
            audioSource.PlayOneShot (audioClip[9]);
            notesT[9].localScale = pos();
            notesS[1].localScale = pos2();
            break;
            case "whiteNote11":
            audioSource.PlayOneShot (audioClip[10]);
            notesT[10].localScale = pos();
            notesS[2].localScale = pos2();
            break;
            case "whiteNote12":
            audioSource.PlayOneShot (audioClip[11]);
            notesT[11].localScale = pos();
            notesS[3].localScale = pos2();
            break;
            case "whiteNote13":
            audioSource.PlayOneShot (audioClip[12]);
            notesT[12].localScale = pos();
            notesS[0].localScale = pos2();
            break;
            case "whiteNote14":
            audioSource.PlayOneShot (audioClip[13]);
            notesT[13].localScale = pos();
            notesS[1].localScale = pos2();
            break;
            case "blackNote1":
            audioSource.PlayOneShot (audioClip[14]);
            notesB[0].localScale = pos1();
            notesS[2].localScale = pos2();
            break;
            case "blackNote2":
            audioSource.PlayOneShot (audioClip[15]);
            notesB[1].localScale = pos1();
            notesS[3].localScale = pos2();
            break;
            case "blackNote3":
            audioSource.PlayOneShot (audioClip[16]);
            notesB[2].localScale = pos1();
            notesS[0].localScale = pos2();
            break;
            case "blackNote4":
            audioSource.PlayOneShot (audioClip[17]);
            notesB[3].localScale = pos1();
            notesS[1].localScale = pos2();
            break;
            case "blackNote5":
            audioSource.PlayOneShot (audioClip[18]);
            notesB[4].localScale = pos1();
            notesS[2].localScale = pos2();
            break;
            case "blackNote6":
            audioSource.PlayOneShot (audioClip[19]);
            notesB[5].localScale = pos1();
            notesS[3].localScale = pos2();
            break;
            case "blackNote7":
            audioSource.PlayOneShot (audioClip[20]);
            notesB[6].localScale = pos1();
            notesS[0].localScale = pos2();
            break;
            case "blackNote8":
            audioSource.PlayOneShot (audioClip[21]);
            notesB[7].localScale = pos1();
            notesS[1].localScale = pos2();
            break;
            case "blackNote9":
            audioSource.PlayOneShot (audioClip[22]);
            notesB[8].localScale = pos1();
            notesS[2].localScale = pos2();
            break;
            case "blackNote10":
            audioSource.PlayOneShot (audioClip[23]);
            notesB[9].localScale = pos1();
            notesS[0].localScale = pos2();
            break;
        }
    }
    //method for transform
    //vector3= 3D of the object that selected in app
    //these are the change size of sprites
    private Vector3 pos(){
        return new Vector3 (1.95f,1.36f,0.95f);
    }

    private Vector3 pos1(){
        return new Vector3 (1.31f,1.33f,1.30f);
    }

    private Vector3 pos2(){
        return new Vector3 (1.2f,1.2f,1.9f);
    }

}
