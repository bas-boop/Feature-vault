using UnityEditor;
using UnityEngine;

[CustomPropertyDrawer(typeof(RangeVector3))]
public class RangeVector3Drawer : PropertyDrawer
{
    public override float GetPropertyHeight(SerializedProperty property, GUIContent label)
        => EditorGUIUtility.singleLineHeight * 2.2f + EditorGUIUtility.standardVerticalSpacing;

    public override void OnGUI(Rect position, SerializedProperty property, GUIContent label)
    {
        if (property.propertyType is SerializedPropertyType.Vector3 or SerializedPropertyType.Vector3Int)
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
            float zMin = position.x + thirdWidth * 2;
            float sliderWidth = thirdWidth - 16f;
            float sliderHeight = EditorGUIUtility.singleLineHeight;

            float spacing = EditorGUIUtility.standardVerticalSpacing;
            float margin = 4f;

            float yPosition = position.y + EditorGUIUtility.singleLineHeight + spacing;

            Vector3 value;

            if (property.propertyType == SerializedPropertyType.Vector3)
            {
                value.x = EditorGUI.Slider(new Rect(xMin, yPosition, sliderWidth, sliderHeight), "X",
                    property.vector3Value.x, rangeAttribute.MinX, rangeAttribute.MaxX);
                
                value.y = EditorGUI.Slider(new Rect(yMin, yPosition, sliderWidth, sliderHeight), "Y",
                    property.vector3Value.y, rangeAttribute.MinY, rangeAttribute.MaxY);
                
                value.z = EditorGUI.Slider(new Rect(zMin, yPosition, sliderWidth, sliderHeight), "Z",
                    property.vector3Value.z, rangeAttribute.MinZ, rangeAttribute.MaxZ);
            }
            else
            {
                value.x = EditorGUI.IntSlider(new Rect(xMin, yPosition, sliderWidth, sliderHeight), "X",
                    property.vector3IntValue.x, Mathf.RoundToInt(rangeAttribute.MinX), Mathf.RoundToInt(rangeAttribute.MaxX));
                
                value.y = EditorGUI.IntSlider(new Rect(yMin, yPosition, sliderWidth, sliderHeight), "Y",
                    property.vector3IntValue.y, Mathf.RoundToInt(rangeAttribute.MinY), Mathf.RoundToInt(rangeAttribute.MaxY));
                
                value.z = EditorGUI.IntSlider(new Rect(zMin, yPosition, sliderWidth, sliderHeight), "Z",
                    property.vector3IntValue.z, Mathf.RoundToInt(rangeAttribute.MinZ), Mathf.RoundToInt(rangeAttribute.MaxZ));
            }

            if (property.propertyType == SerializedPropertyType.Vector3)
                property.vector3Value = value;
            else
                property.vector3IntValue = new Vector3Int(Mathf.RoundToInt(value.x), Mathf.RoundToInt(value.y), Mathf.RoundToInt(value.z));

            EditorGUIUtility.labelWidth = labelWidth;
            EditorGUI.indentLevel--;

            if (EditorGUI.EndChangeCheck())
            {
                var targetVector = property.propertyType == SerializedPropertyType.Vector3 
                    ? property.vector3Value 
                    : property.vector3IntValue;
                
                targetVector.x = Mathf.Clamp(targetVector.x, rangeAttribute.MinX, rangeAttribute.MaxX);
                targetVector.y = Mathf.Clamp(targetVector.y, rangeAttribute.MinY, rangeAttribute.MaxY);
                targetVector.z = Mathf.Clamp(targetVector.z, rangeAttribute.MinZ, rangeAttribute.MaxZ);

                if (property.propertyType == SerializedPropertyType.Vector3)
                    property.vector3Value = targetVector;
                else
                    property.vector3IntValue = new Vector3Int(Mathf.RoundToInt(targetVector.x), Mathf.RoundToInt(targetVector.y), Mathf.RoundToInt(targetVector.z));
            }

            EditorGUI.EndProperty();
        }
        else
            EditorGUI.HelpBox(position, "RangeVector3 can only be used with Vector3 or Vector3Int fields.", MessageType.Error);
    }
}