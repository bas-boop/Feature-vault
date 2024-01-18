using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float @float;
    [SerializeField] private Vector2 vector2;
    [SerializeField] private Vector3 vector3;
    [SerializeField] private Vector2Int vector2Int;
    [SerializeField] private Vector3Int vector3Int;
    [Header("Sliders")]
    [SerializeField, Range(0,10)] private float rangedFloat;
    [SerializeField, RangeVector2(0,10,5,20)] private Vector2 rangedVector2;
    [SerializeField, RangeVector2(0,10,5,20)] private Vector2Int rangedVector2Int;
    [SerializeField, RangeVector3(0,10,5,20, 15, 1000)] private Vector3 rangedVector3;
    [SerializeField, RangeVector3(0,10,5,20, 15, 1000)] private Vector3Int rangedVector3Int;
}
