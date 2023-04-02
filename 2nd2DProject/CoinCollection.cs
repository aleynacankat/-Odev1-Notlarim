using System;
using SystemCollections;
using SystemCollections.Generic;
using UnityEngine;

public class CoinCollection : MonoBehaviour
{
    private AudioSource click;
    private void Start()
    {
        click = GetComponent<AudioSource>();
    }



    private void OnTriggerEnter(Collider Other)
    {
        if(other.gameObject.CompareTag("coin"))
        {
            Destroy(other.gameObject);
            other.gameObject.SetActive(false);
            click.Play();
            StartCoroutine(Spawn(other.gameObject));
        }
    }

    IEnumerator Spawn(GameObject gameObject)
    {
        //3 saniye sonra active state döner
        yield return new WaitForSeconds(3);
        gameObject.SetActive(true);
    }

}
