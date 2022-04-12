using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.InputSystem;

public class FlashlightToggle : MonoBehaviour
{
    public GameObject flashlight;
    public InputActionReference toggleReference;

    // Start is called before the first frame update
    private void Awake()
    {
        toggleReference.action.started += Toggle;
    }

    // Update is called once per frame
    void OnDestroy()
    {
        toggleReference.action.started -= Toggle;
    }

    private void Toggle(InputAction.CallbackContext context)
    {
        bool isActive = !flashlight.gameObject.activeSelf;
        flashlight.gameObject.SetActive(isActive);
    }
}
