using UnityEngine;
using Baz_geluk9.Feature_vault.Extensions;

namespace Baz_geluk9.Feature_vault.Examples
{
    public class VectorRangesExample : MonoBehaviour
    {
        [Header("Float")]
        [SerializeField] private float @float;
        [SerializeField, Range(0,10)] private float rangedFloat;
        
        [Space(50)]
        [Header("Vector2")]
        [SerializeField] private Vector2 vector2;
        [SerializeField, RangeVector2(0,10,5,20)] private Vector2 rangedVector2;
        
        [Space(50)]
        [Header("Vector2Int")]
        [SerializeField] private Vector2Int vector2Int;
        [SerializeField, RangeVector2(0,10,5,20)] private Vector2Int rangedVector2Int;
        
        [Space(50)]
        [Header("Vector3")]
        [SerializeField] private Vector3 vector3;
        [SerializeField, RangeVector3(0,10,5,20, 15, 1000)] private Vector3 rangedVector3;

        [Space(50)]
        [Header("Vector3Int")]
        [SerializeField] private Vector3Int vector3Int;
        [SerializeField, RangeVector3(0,10f,5,20, 15, 1000)] private Vector3Int rangedVector3Int;
    }   
}
