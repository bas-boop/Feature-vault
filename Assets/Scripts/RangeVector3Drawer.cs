using Baz_geluk9.Feature_vault.Extensions;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(RangeVector3))]
public class RangeVector3Drawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) + EditorGUIUtility.standardVerticalSpacing * 10;
    }
    
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.Vector3)
        {
            EditorGUI.BeginProperty(position, label, property);

            RangeVector3 rangeAttribute = attribute as RangeVector3;

            EditorGUI.BeginChangeCheck();
            EditorGUI.LabelField(new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight), label);
            EditorGUI.indentLevel++;

            float labelWidth = EditorGUIUtility.labelWidth;

            EditorGUIUtility.labelWidth = 12f;

            float thirdWidth = position.width / 3f;
            float xMin = position.x;
            float yMin = position.x + thirdWidth;
            float zMin = position.x + 2f * thirdWidth;
            float sliderWidth = thirdWidth - 16f;
            float sliderHeight = EditorGUIUtility.singleLineHeight;
            float margin = -5f;
            float yPosition = position.y + EditorGUIUtility.singleLineHeight + margin;
            float xValue = EditorGUI.Slider(new Rect(xMin, yPosition, sliderWidth, sliderHeight), "X", property.vector3Value.x, rangeAttribute.MinX, rangeAttribute.MaxX);
            float yValue = EditorGUI.Slider(new Rect(yMin, yPosition, sliderWidth, sliderHeight), "Y", property.vector3Value.y, rangeAttribute.MinY, rangeAttribute.MaxY);
            float zValue = EditorGUI.Slider(new Rect(zMin, yPosition, sliderWidth, sliderHeight), "Z", property.vector3Value.z, rangeAttribute.MinZ, rangeAttribute.MaxZ);

            property.vector3Value = new Vector3(xValue, yValue, zValue);

            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel--;

            if (EditorGUI.EndChangeCheck())
            {
                var targetVector = property.vector3Value;
                targetVector.SetX(Mathf.Clamp(property.vector3Value.x, rangeAttribute.MinX, rangeAttribute.MaxX));
                targetVector.SetY(Mathf.Clamp(property.vector3Value.y, rangeAttribute.MinY, rangeAttribute.MaxY));
                targetVector.SetZ(Mathf.Clamp(property.vector3Value.z, rangeAttribute.MinZ, rangeAttribute.MaxZ));
                property.vector3Value = targetVector;
            }

            EditorGUI.EndProperty();
        }
        else
            EditorGUI.HelpBox(position, "RangeVector3 can only be used with Vector3 fields.", MessageType.Error);
    }
}
