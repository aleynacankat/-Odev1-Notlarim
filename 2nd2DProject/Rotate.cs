using System;
using SystemCollections;
using SystemCollectionsGeneric;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    [SerializeField] private float speedX;
    [SerializeField] private float speedY;
    [SerializeField] private float speedZ;

    void Update(){
    transform.rotate(360 * speedX * Time.deltaTime, 360 * speedY * Time.deltaTime, 360 * speedZ * Time.deltaTime);
    }

}

