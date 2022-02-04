using System.Linq;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundGeneration : MonoBehaviour
{
    [Tooltip("Square-shaped tile")]
    [SerializeField] Renderer _groundTile;
    [Tooltip("Fill world around targer in specified area round")]
    [SerializeField] Transform _target; //todo create Tile type
    [SerializeField] float _areaAroundTarget;

    private Dictionary<Vector2, GameObject> _tiles;
    private Pool<Transform> _pool;
    private float _tileSize;
    private int _surroundingTiles => (int)(_areaAroundTarget / _tileSize);
    private Vector2 _cuttentTile => new Vector2(Mathf.RoundToInt(_target.position.x / _tileSize), Mathf.RoundToInt(_target.position.z / _tileSize));
    private Vector3 _currentTileVector3 => new Vector3(_cuttentTile.x, 0f, _cuttentTile.y);

    private IEnumerator UpdateWorld()
    {
        Vector2 previousPosition = new Vector2(_target.position.x, _target.position.z);
        ReconstructWorld();
        while (true)
        {
            var currentPosition = new Vector2(_target.position.x, _target.position.z);
            if((previousPosition - currentPosition).magnitude > _tileSize)
            {
                ReconstructWorld();
                previousPosition = new Vector2(_target.position.x, _target.position.z);
            }
            yield return null;
        }
    }

    private void ReconstructWorld()
    {
        List<Vector2> newTiles = new List<Vector2>(4 * _surroundingTiles * _surroundingTiles);
        for (int x = -_surroundingTiles; x < _surroundingTiles; x++)
        {
            for (int y = -_surroundingTiles; y < _surroundingTiles; y++)
            {
                newTiles.Add(new Vector2(x, y) + _cuttentTile);
            }
        }
        var cre = newTiles.Except(_tiles.Keys);
        var del = _tiles.Keys.Except(newTiles);
        Debug.Log("create/Delete" + cre.Count() + "/" + del.Count());

        CreateTiles(cre);
        DeleteTiles(del);
    }

    private void CreateTiles(IEnumerable<Vector2> tilesToCreate)
    {
        foreach (var tilePosition in tilesToCreate)
        {
            var tile = _pool.GetObject();
            tile.localPosition = new Vector3(tilePosition.x, 0f, tilePosition.y) * _tileSize;
            _tiles.Add(tilePosition, tile.gameObject);
        }
    }

    private void DeleteTiles(IEnumerable<Vector2> tilesToDelete)
    {
        foreach (var tilePosition in tilesToDelete.ToList())
        {
            _pool.StoreObject(_tiles[tilePosition].transform);
            _tiles.Remove(tilePosition);
        }
    }

    private void Awake()
    {
        _tileSize = _groundTile.bounds.size.x;
        _tiles = new Dictionary<Vector2, GameObject>();
        _pool = new Pool<Transform>(_groundTile.transform, transform);
    }

    private void Start()
    {
        StartCoroutine(UpdateWorld());
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.DrawWireSphere(_target.position, _areaAroundTarget);
    }
}
