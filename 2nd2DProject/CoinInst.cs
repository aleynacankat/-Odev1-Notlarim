using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = System.Random;

public class PowerUp : CoinInst
{
    public List<transform> spawnPoints = new List<Transform>();
    [SerializeField] private GameObject coin;
    
    private void Start()
    {
        var r = new Random();
        int a  = (int)Math.Ceiling(spawnPoints.Count/2.0f); 

        HashSet<int> randomValues = newHash

        var randomValues = Enumerable.Range(0,a)
            .Select(e => spawnPoints[r.Next(spawnPoints.Count)]);

        //Debug.Log(randomValues.Count() + " " + a);
        foreach (var transform in randomValues)
        {
            Instantiate(coin, transform);
        }
    }
}