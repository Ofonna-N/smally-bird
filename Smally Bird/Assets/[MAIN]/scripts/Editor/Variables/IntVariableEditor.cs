
using UnityEditor;
using UnityEngine.UIElements;
using UnityEditor.UIElements;
using SmallyBird;
using UnityEditor.Graphs;
using System.Diagnostics;

[CustomEditor(typeof(IntVariable))]
public class IntVariableEditor : Editor
{
    public VisualTreeAsset visualTree;

    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        visualTree.CloneTree(root);
        var button = root.Q<Button>();
        button.clicked += () => 
        {
            OnReset(root);
        };

        return root;
    }


    private void OnReset(VisualElement root)
    {
        root.Q<IntegerField>().value = 0;
        //UnityEngine.Debug.Log("Testing button");
    }
}
