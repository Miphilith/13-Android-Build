using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    private UIDocument uiDoc;
    private VisualElement root;
    private Button login_Button;

    void Start()
    {
        uiDoc = GetComponent<UIDocumentPortrais>();
        root = uiDoc.rootVisualElement;
        Debug.Log(root.name);
        login_Button = root.Q<Button>("Login");

        login_Button.clicked += Login;
    }

    private void Login()
    {
        root.style.display = DisplayStyle.None;
    }
}
