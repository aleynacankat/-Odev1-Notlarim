using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using StarterAssets;
using MusicFilesNM;

public class PowerUp : MonoBehaviour
{
    private GameObject _music;
    private MusicFiles _musicFiles;
    private ThirdPersonController _thirdPersonController;
    [SerializeField] private int Number;

    private void Start()
    {
        _music = GameObject.Find("AudioManager");
        _musicFiles = _music.GetComponent(typeof(MusicFiles)) as MusicFiles;
        _thirdPersonController = GetComponent<ThirdPersonController>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("powerup"))
        {
            Destroy(other.gameObject);
            AudioSource.PlayClipAtPoint(_musicFiles.music[0], gameObject.transform.position);
            _thirdPersonController.SprintSpeed = 10.0f;
            Invoke("BackToNormalSpeed", 3.0f);            
        }
    }

    private void BackToNormalSpeed()
    {
        _thirdPersonController.SprintSpeed = 5.33f;
    }

}