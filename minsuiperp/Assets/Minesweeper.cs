using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Minesweeper : MonoBehaviour
{
    [SerializeField]
    private int _rows = 1;

    [SerializeField]
    private int _colums = 1;

    [SerializeField]
    private GridLayoutGroup gridLayoutGroup = null;

    [SerializeField]
    private Cell cellPrefab = null;

   void Start()
    {
        var parent = gridLayoutGroup.gameObject.transform;
        for(var r=0;r<_rows;r++)
        {
            for(var k=0;k<_colums;k++)
            {
                var cel = Instantiate(cellPrefab);
                cel.transform.SetParent(parent);
            }
        }
    }

}
