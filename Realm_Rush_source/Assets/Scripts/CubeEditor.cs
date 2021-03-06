﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[SelectionBase]
public class CubeEditor : MonoBehaviour
{
    [Range(1f, 20f)]
    [SerializeField] float gridSize = 10f;

    TextMesh textMesh;

    Vector3 snapPos;

    private void Awake()
    {
        textMesh = GetComponentInChildren<TextMesh>();
    }

    void Update ()
    {
        snapPos.x = Mathf.RoundToInt(transform.position.x / gridSize) * gridSize;
        snapPos.z = Mathf.RoundToInt(transform.position.z / gridSize) * gridSize;

        transform.position = new Vector3(snapPos.x, 0f, snapPos.z);

        string labelText = (snapPos.x / gridSize) + "," + (snapPos.z / gridSize);
        textMesh.text = labelText;

        gameObject.name = labelText;
    }
}
