
using UnityEngine;
using UnityEngine.Events;

public class MonoEvents : MonoBehaviour
{
    public UnityEvent startEvent;
    
    private void Start()
    {
        startEvent.Invoke();
    }

    
}
