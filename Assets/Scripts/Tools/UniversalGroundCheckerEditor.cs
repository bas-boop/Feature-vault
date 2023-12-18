#if UNITY_EDITOR
using Baz_geluk9.Feature_vault.Feature;
using UnityEditor;

namespace Baz_geluk9.Feature_vault.Tool
{
    /// <summary>
    /// Custom editor script for UniversalGroundChecker to enhance the Unity Editor interface.
    /// </summary>
    [CustomEditor(typeof(UniversalGroundChecker))]
    public class UniversalGroundCheckerEditor : Editor
    {
        private SerializedProperty _is3D;
        private SerializedProperty _lineOrSphere;
        private SerializedProperty _offSetOrTransform;
        private SerializedProperty _groundLayer;
        private SerializedProperty _rayLenght;
        private SerializedProperty _rayRadius;
        private SerializedProperty _offSet2D;
        private SerializedProperty _offSet3D;
        private SerializedProperty _transform;
        private SerializedProperty _gizmos;
        private SerializedProperty _gizmosColor;
        private SerializedProperty _isGrounded;
        private SerializedProperty _onGroundEnter;
        private SerializedProperty _onGroundLeave;

        private void OnEnable()
        {
            _is3D = serializedObject.FindProperty("is3D");
            _lineOrSphere = serializedObject.FindProperty("lineOrSphere");
            _offSetOrTransform = serializedObject.FindProperty("offSetOrTransform");
            _groundLayer = serializedObject.FindProperty("groundLayer");
            _rayLenght = serializedObject.FindProperty("rayCastLength");
            _rayRadius = serializedObject.FindProperty("sphereCastRadius");
            _offSet2D = serializedObject.FindProperty("offSet2D");
            _offSet3D = serializedObject.FindProperty("offSet3D");
            _transform = serializedObject.FindProperty("groundCheckerTransform");
            _gizmos = serializedObject.FindProperty("gizmos");
            _gizmosColor = serializedObject.FindProperty("gizmosColor");
            _isGrounded = serializedObject.FindProperty("isGrounded");
            _onGroundEnter = serializedObject.FindProperty("onGroundEnter");
            _onGroundLeave = serializedObject.FindProperty("onGroundLeave");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.PropertyField(_is3D);
            EditorGUILayout.PropertyField(_lineOrSphere);
            EditorGUILayout.PropertyField(_offSetOrTransform);
            EditorGUILayout.PropertyField(_groundLayer);

            EditorGUILayout.PropertyField(_lineOrSphere.boolValue ? _rayLenght : _rayRadius);

            switch (_offSetOrTransform.boolValue)
            {
                case false:
                    EditorGUILayout.PropertyField(_is3D.boolValue ? _offSet3D : _offSet2D);
                    break;
                case true:
                    EditorGUILayout.PropertyField(_transform);
                    break;
            }
            
            EditorGUILayout.PropertyField(_isGrounded);
            EditorGUILayout.PropertyField(_gizmos);
            EditorGUILayout.PropertyField(_gizmosColor);

            EditorGUILayout.PropertyField(_onGroundEnter);
            EditorGUILayout.PropertyField(_onGroundLeave);

            serializedObject.ApplyModifiedProperties();
        }
    }
}
#endif