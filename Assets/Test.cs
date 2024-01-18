using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    [SerializeField] private float number;
    [SerializeField] private Vector2 a;
    [SerializeField] private Vector3 b;
    [SerializeField] private Vector2 c;
    [SerializeField] private Vector3 d;
    [Header("Sliders")]
    [SerializeField, Range(0,10)] private float numberYes;
    [SerializeField, RangeVector2(0,10,5,20)] private Vector2 aYes;
    [SerializeField, RangeVector3(0,10,5,20, 15, 1000)] private Vector3 bYes;
}
