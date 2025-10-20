using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class ThrowableObject : MonoBehaviour
{
    private XRGrabInteractable _grabInteractable;
    public float throwStrength = 2f;
    public float maxAngle = 20f;

    void Start()
    {
        _grabInteractable = GetComponent<XRGrabInteractable>();
        _grabInteractable.selectExited.AddListener(OnRelease);
    }


    private void OnRelease(SelectExitEventArgs args)
    {

        Rigidbody rb = GetComponent<Rigidbody>();
    
    
        float randomAngle = Random.Range(-maxAngle, maxAngle);
    
        Vector3 throwDirection = new Vector3(
            Mathf.Sin(randomAngle * Mathf.Deg2Rad), 
            0,
            Mathf.Cos(randomAngle * Mathf.Deg2Rad)  
        );
    
        rb.AddForce(throwDirection * throwStrength, ForceMode.Impulse);
    }

    void OnDestroy()
    {
        _grabInteractable.selectExited.RemoveListener(OnRelease);
    }
}