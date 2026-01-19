using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using TMPro;
using Unity.Collections.LowLevel.Unsafe;
using Unity.VisualScripting;
using UnityEngine;

public class Ui : MonoBehaviour
{
    [SerializeField] private TMP_Text _coinPoints;
    [SerializeField] private GameObject _coinPrefab;

    [SerializeField] float _spawnY = 2f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void SpawnCoin()
    {
        // instantiate coin randomly on screen in a line with not-perfectly-regular intervals (this could be random or in a pattern). 

        float _randomX = Random.Range(-10f, 10f);
        Vector3 spawnPosition = new Vector3(_randomX, _spawnY, 0f);

        Instantiate(_coinPrefab, spawnPosition, UnityEngine.Quaternion.identity); 
    }
    public void UpdateCoinText(int coinCollected)
    {
        // When the player hits the coin, they Gain a point, which updates text in the UI. 
        _coinPoints.text = "Points: " + coinCollected;
    }
}
