using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingSpawner : MonoBehaviour
{
    [SerializeField] private Block _block;
    [SerializeField] private Transform _buildPoint;
    [SerializeField] private float _buildingSize;

    private List<Block> _blocks;

    private void Start()
    {
        BuildBlocks();
    }

    private List<Block> BuildBlocks()
    {
        _blocks = new List<Block>();

        Transform currentPoint = _buildPoint;

        for (int i = 0; i < _buildingSize; i++)
        {
            Vector3 currentPos = GetBuildPoint(currentPoint);
            Block block = Instantiate(_block, currentPos, Quaternion.identity, _buildPoint);
            _blocks.Add(block);
            currentPoint = block.transform;
        }
        return _blocks;
    }

    private Block BuildBlock(Transform currentBuildPoint)
    {
        return Instantiate(_block, GetBuildPoint(currentBuildPoint), Quaternion.identity, _buildPoint);
    }

    private Vector3 GetBuildPoint(Transform currentSegment)
    {
        return new Vector3(_buildPoint.position.x,
            currentSegment.position.y + currentSegment.localScale.y / 2 + _block.transform.localScale.y / 2 + 1,
            _buildPoint.position.z);
    }
}
