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
        for (int i = 0; i < uiDocs.Length; i++)
        {
            //SetUIDoc(uiDocs[i]);
        }
    }

    void Update()
    {
        float ratio = (float)Screen.width/(float)Screen.height;
        ToggleUIDoc(ratio);
    }

    private void SetUIDoc(UIDocument uiDoc)
    {
        uiDoc = GetComponent<UIDocument>();
        VisualElement root = uiDoc.rootVisualElement;
        Button login_Button = root.Q<Button>("Login");

        //login_Button.clicked += Login;
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
        }
        else
        {
            uiDocs[1].rootVisualElement.style.display = DisplayStyle.Flex;
            uiDocs[0].rootVisualElement.style.display = DisplayStyle.None;
        }
    }
}
