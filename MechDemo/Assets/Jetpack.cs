using UnityEngine.InputSystem;
using UnityEngine;
using Unity.XR.CoreUtils;

public class Jetpack : MonoBehaviour
{
    public InputActionReference jetpackInputActionReference;
    public float jetpackForce;

    private Rigidbody _playerRb;
    private float _triggerValue;

    // Start is called before the first frame update
    void Start()
    {
        _playerRb = FindObjectOfType<XROrigin>().GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        _playerRb.AddForce(-transform.forward * (_triggerValue * jetpackForce * Time.deltaTime), ForceMode.Force);
    }
    private void OnEnable()
    {
        jetpackInputActionReference.action.Enable();
        jetpackInputActionReference.action.performed += SetTriggerValue;
    }

    private void OnDisable()
    {
        jetpackInputActionReference.action.Disable();
        jetpackInputActionReference.action.performed -= SetTriggerValue;
    }

    private void SetTriggerValue(InputAction.CallbackContext obj)
    {
        _triggerValue = obj.ReadValue<float>();
    }
}
