using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    [SerializeField]
    private UIDocument[] uiDocs;

    void Start()
    {
        float ratio = (float)Screen.width / (float)Screen.height;
        ToggleUIDoc(ratio);
    }

    void Update()
    {
        if (Input.deviceOrientation == DeviceOrientation.Portrait)
        {
            float ratio = (float)Screen.width / (float)Screen.height;
            ToggleUIDoc(ratio);
        }
        else if (Input.deviceOrientation == DeviceOrientation.LandscapeLeft|| Input.deviceOrientation == DeviceOrientation.LandscapeRight)
        {
            float ratio = (float)Screen.width / (float)Screen.height;
            ToggleUIDoc(ratio);
        }
    }

    private void SetUIDoc(UIDocument uiDoc)
    {
        VisualElement root = uiDoc.rootVisualElement;
        Button login_Button = root.Q<Button>("Login");

        login_Button.clicked += () => Login(root);
    }

    private void Login(VisualElement root)
    {
        root.style.display = DisplayStyle.None;
    }

    private void ToggleUIDoc(float ratio)
    {
        if (ratio > 2)
        {
            uiDocs[0].rootVisualElement.style.display = DisplayStyle.Flex;
            uiDocs[1].rootVisualElement.style.display = DisplayStyle.None;
            SetUIDoc(uiDocs[0]);
        }
        else
        {
            uiDocs[1].rootVisualElement.style.display = DisplayStyle.Flex;
            uiDocs[0].rootVisualElement.style.display = DisplayStyle.None;
            SetUIDoc(uiDocs[1]);
        }
    }
}
