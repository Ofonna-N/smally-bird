using UnityEditor.UIElements;
using UnityEngine.UIElements;
using UnityEngine;
using UnityEditor;
using SmallyBird;
using System.Diagnostics;
using Codice.CM.WorkspaceServer.Tree.GameUI.Checkin.Updater;

[CustomEditor(typeof(BasicEventListener))]
public class BasicEevntListenerEditor : Editor
{
    [SerializeField]
    private VisualTreeAsset visualTree;

    PropertyField checkAgainstEventsFlag;
    PropertyField eventsToCheck;

    public override VisualElement CreateInspectorGUI()
    {
        var root = new VisualElement();

        visualTree.CloneTree(root);

        checkAgainstEventsFlag = root.Q<PropertyField>("check-against-evts");
        eventsToCheck = root.Q<PropertyField>("evts-to-check");

        //UnityEngine.Debug.Log(checkAgainstEventsFlag.userData);

        checkAgainstEventsFlag.RegisterCallback<ChangeEvent<bool>>((ChangeEvent<bool> evt) => 
        {
            //UnityEngine.Debug.Log("Boolean changed!");
            if (evt.newValue == true)
            {
                eventsToCheck.style.display = DisplayStyle.Flex;
            }
            else
            {
                eventsToCheck.style.display = DisplayStyle.None;
            }
        });

        return root;
    }

    //private void OnTestToggleChanged(ChangeEvent<bool> evt)
    //{
    //    //UnityEngine.Debug.Log("Boolean changed!");
    //}

}
