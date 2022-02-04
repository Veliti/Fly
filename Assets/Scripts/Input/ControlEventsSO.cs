using System;
using UnityEngine;
using UnityEngine.InputSystem;

[CreateAssetMenu(menuName = "SObjects / Input")]
public class ControlEventsSO : ScriptableObject, Controls.IShipActions
{
    public event Action<Vector2> MoveCharacter;
    public event Action<Vector2> MoveCameraDelta;
    public event Action<float> BarrelRotation;
 
    private Controls _controls;

    void Controls.IShipActions.OnMoveCharacter(InputAction.CallbackContext context)
    {
        MoveCharacter?.Invoke(context.ReadValue<Vector2>());
    }

    void Controls.IShipActions.OnMoveCamera(InputAction.CallbackContext context)
    {
        MoveCameraDelta?.Invoke(context.ReadValue<Vector2>());
    }

    void Controls.IShipActions.OnBarrelRotate(InputAction.CallbackContext context)
    {
        BarrelRotation?.Invoke(context.ReadValue<float>());
    }

    private void OnEnable()
    {
        _controls = new Controls();
        _controls.Enable();
        _controls.Ship.SetCallbacks(this);
    }

    private void OnDisable()
    {
        _controls.Disable();
    }


}
