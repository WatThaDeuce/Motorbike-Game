using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class GameplayInputHandler : MonoBehaviour
{
    public float ThrottleInput;
    public float BrakeInput;
    public float SteeringInput;

    public UnityEvent GearUp;
    public UnityEvent GearDown;

    [SerializeField]
    private PlayerInput input;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SteeringInput = input.actions.FindAction("Steering").ReadValue<float>();
        ThrottleInput = input.actions.FindAction("Throttle").ReadValue<float>();
        BrakeInput = input.actions.FindAction("Brake").ReadValue<float>();
        // Debug.Log(SteeringInput);
    }

    public void OnGearUp()
    {
        GearUp.Invoke();
    }
    public void OnGearDown()
    {
        GearDown.Invoke();
    }
}
