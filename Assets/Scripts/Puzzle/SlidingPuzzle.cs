using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlidingPuzzle : MonoBehaviour
{
    private int[,] puzzle;

	void Start ()
    {
        puzzle = new int[,]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {12, 11, 10, 9},
            {13, 14, 15, 0}
        };
	}
}
