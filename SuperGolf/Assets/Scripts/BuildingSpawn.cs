using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawn : MonoBehaviour
{
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private Block _block;

    private void Start()
    {
        Instantiate(_block, _spawnPoint.position, Quaternion.identity);
    }
}
