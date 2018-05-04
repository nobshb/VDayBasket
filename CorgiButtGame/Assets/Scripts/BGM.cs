using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGM : MonoBehaviour {

    public AudioSource backgroundMusic;

    public static GameObject bgmObject;

    void Awake()
    {
        if (bgmObject)
        {
            return;
        }
        //backgroundMusic;
        bgmObject = gameObject;
    }
}
