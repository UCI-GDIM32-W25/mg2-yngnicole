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

    //[SerializeField] float _spawnY = 2f;
    [SerializeField] float _minSpawnTime = 0.5f;
    [SerializeField] float _maxSpawnTime = 2f;

    private float _spawnTimer;

    void Start()
    {
        SpawnCoin();
        ResetSpawnTimer();
    }

    private void Update()
    {
       _spawnTimer -= Time.deltaTime;
        if (_spawnTimer <= 0f)
        {
            SpawnCoin();
            ResetSpawnTimer();
        }
    }

    void ResetSpawnTimer()
    {
        _spawnTimer = Random.Range(_minSpawnTime, _maxSpawnTime);
    }

    public void SpawnCoin()
    {
        // instantiate coin randomly on screen in a line with not-perfectly-regular intervals (this could be random or in a pattern) infinitely.

        //float randomX = Random.Range(-10f, 10f);
        Vector3 spawnPosition = new Vector3(14.1f, 13.47f, 0f);

        Instantiate(_coinPrefab, spawnPosition, UnityEngine.Quaternion.identity); 
    }

    public void UpdateCoinText(int coinCollected)
    {
        // When the player hits the coin, they Gain a point, which updates text in the UI. 
        _coinPoints.text = "Points: " + coinCollected;
    }
}
