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
        if (property.propertyType is SerializedPropertyType.Vector2 or SerializedPropertyType.Vector2Int)
        {
            EditorGUI.BeginProperty(position, label, property);
            
            RangeVector2 rangeAttribute = attribute as RangeVector2;

            EditorGUI.BeginChangeCheck();
            EditorGUI.LabelField(new Rect(position.x, position.y, position.width, EditorGUIUtility.singleLineHeight), label);
            EditorGUI.indentLevel++;

            float labelWidth = EditorGUIUtility.labelWidth;
            
            EditorGUIUtility.labelWidth = 12f;

            float halfWidth = position.width / 2f;
            float xMin = position.x;
            float yMin = position.x + halfWidth;
            float sliderWidth = halfWidth - 16f;
            float sliderHeight = EditorGUIUtility.singleLineHeight;

            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float margin = 4f;

            float yPosition = position.y + EditorGUIUtility.singleLineHeight + spacing;

            Vector2 value;

            if (property.propertyType == SerializedPropertyType.Vector2)
            {
                if (rangeAttribute != null)
                {
                    value.x = EditorGUI.Slider(new Rect(xMin, yPosition, sliderWidth, sliderHeight), "X",
                        property.vector2Value.x, rangeAttribute.MinX, rangeAttribute.MaxX);

                    value.y = EditorGUI.Slider(new Rect(yMin, yPosition, sliderWidth, sliderHeight), "Y",
                        property.vector2Value.y, rangeAttribute.MinY, rangeAttribute.MaxY);
                }
                else
                    value = Vector2.one;
            }
            else
            {
                if (rangeAttribute != null)
                {
                    value.x = EditorGUI.IntSlider(new Rect(xMin, yPosition, sliderWidth, sliderHeight), "X",
                        property.vector2IntValue.x, Mathf.RoundToInt(rangeAttribute.MinX),
                        Mathf.RoundToInt(rangeAttribute.MaxX));

                    value.y = EditorGUI.IntSlider(new Rect(yMin, yPosition, sliderWidth, sliderHeight), "Y",
                        property.vector2IntValue.y, Mathf.RoundToInt(rangeAttribute.MinY),
                        Mathf.RoundToInt(rangeAttribute.MaxY));
                }
                else
                    value = Vector2.one;
            }

            if (property.propertyType == SerializedPropertyType.Vector2)
                property.vector2Value = value;
            else
                property.vector2IntValue = new Vector2Int(Mathf.RoundToInt(value.x), Mathf.RoundToInt(value.y));

            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel--;

            if (EditorGUI.EndChangeCheck())
            {
                var targetVector = property.propertyType == SerializedPropertyType.Vector2 
                    ? property.vector2Value 
                    : property.vector2IntValue;
                
                targetVector.x = Mathf.Clamp(targetVector.x, rangeAttribute.MinX, rangeAttribute.MaxX);
                targetVector.y = Mathf.Clamp(targetVector.y, rangeAttribute.MinY, rangeAttribute.MaxY);

                if (property.propertyType == SerializedPropertyType.Vector2)
                    property.vector2Value = targetVector;
                else
                    property.vector2IntValue = new Vector2Int(Mathf.RoundToInt(targetVector.x), Mathf.RoundToInt(targetVector.y));
            }

            EditorGUI.EndProperty();
        }
        else
            EditorGUI.HelpBox(position, "RangeVector2 can only be used with Vector2 fields.", MessageType.Error);
    }
}