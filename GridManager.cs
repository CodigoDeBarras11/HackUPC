using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] private int _width, _height;
    [SerializeField] private Tile _tilePrefab;
    [SerializeField] private Transform _cam;
    
    
    void Start() 
    {
        GenerateGrid();   
    }
    
    void GenerateGrid()
    {
       /* for (int i = -9; i < _width - 6; ++i) {
            for (int j = -5; j < _height - 3; ++j) {
                var spawnedTile = Instantiate(_tilePrefab, new Vector3(i, j), Quaternion.identity);
                spawnedTile.name = $"Tile {i} {j}";
                var isOffset = (i % 2 == 0 && j % 2 != 0) || (i % 2 != 0 && j % 2 == 0);
                spawnedTile.Init(isOffset);
            }
        }*/
        //_cam.transform.position = new Vector3((float)_width / 2 -0.5f, (float)_height / 2 -0.5f, -10);
    }
}
