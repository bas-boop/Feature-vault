using Baz_geluk9.Feature_vault.Extensions;
using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(RangeVector2))]
public class RangeVector2Drawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
    {
        return base.GetPropertyHeight(property, label) + EditorGUIUtility.standardVerticalSpacing * 10;
    }
    
    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType == SerializedPropertyType.Vector2)
        {
            EditorGUI.BeginProperty(position, label, property);

            RangeVector2 rangeAttribute = attribute as RangeVector2;

            EditorGUI.BeginChangeCheck();
            EditorGUI.LabelField(new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight), label);
            EditorGUI.indentLevel++;

            float labelWidth = EditorGUIUtility.labelWidth;
            
            EditorGUIUtility.labelWidth = 12f;

            float halfWidth = position.width * 0.5f;
            float xMin = position.x;
            float yMin = position.x + halfWidth;
            float sliderWidth = halfWidth - 16f;
            float xValue = EditorGUI.Slider(new Rect(xMin, position.y + EditorGUIUtility.singleLineHeight, sliderWidth, EditorGUIUtility.singleLineHeight), "X", property.vector2Value.x, rangeAttribute.MinX, rangeAttribute.MaxX);
            float yValue = EditorGUI.Slider(new Rect(yMin, position.y + EditorGUIUtility.singleLineHeight, sliderWidth, EditorGUIUtility.singleLineHeight), "Y", property.vector2Value.y, rangeAttribute.MinY, rangeAttribute.MaxY);

            property.vector2Value = new Vector2(xValue, yValue);

            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel--;

            if (EditorGUI.EndChangeCheck())
            {
                var targetVector = property.vector2Value;
                targetVector.SetX(Mathf.Clamp(property.vector2Value.x, rangeAttribute.MinX, rangeAttribute.MaxX));
                targetVector.SetY(Mathf.Clamp(property.vector2Value.y, rangeAttribute.MinY, rangeAttribute.MaxY));
                property.vector2Value = targetVector;
            }

            EditorGUI.EndProperty();
        }
        else
            EditorGUI.HelpBox(position, "RangeVector2 can only be used with Vector2 fields.", MessageType.Error);
    }
}