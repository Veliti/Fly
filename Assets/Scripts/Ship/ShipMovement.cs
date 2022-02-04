using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ShipMovement : MonoBehaviour
{
    [SerializeField] ControlEventsSO _shipControls;
    [Header("Ship Settings")]
    [SerializeField] float _forwardSpeed;
    [SerializeField] float _sideSpeed;
    [SerializeField] float _rotationSpeed;
    [SerializeField] float _barrelRotationSpeed;

    private Rigidbody _rigidbody;
    private Vector2 _moveDiraction;
    private Vector2 _rotateDiraction;
    private float _barrelRotation;

    private void UpdateDiraction (Vector2 newDiraction) => _moveDiraction = newDiraction;
    private void UpdateRotateDiraction(Vector2 newDiraction) => _rotateDiraction = newDiraction;
    private void UpdateBarrelRotation(float newDiraction) => _barrelRotation = newDiraction;

    private void MoveShip()
    {
        var move = new Vector3(_moveDiraction.y * _sideSpeed, 0, -_moveDiraction.x * _forwardSpeed) * Time.deltaTime;
        _rigidbody.MovePosition(_rigidbody.position + _rigidbody.rotation * move);
    }

    private void RotateShip()
    {
        var rotate = new Vector3(0, _rotateDiraction.x, _rotateDiraction.y) * _rotationSpeed 
                    + new Vector3(_barrelRotation * _barrelRotationSpeed * Time.deltaTime, 0, 0);
        _rigidbody.MoveRotation(_rigidbody.rotation * Quaternion.Euler(rotate));
    }

    private void Update()
    {
        MoveShip();
        RotateShip();
    }

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
    }

    private void OnEnable()
    {
        _shipControls.MoveCharacter += UpdateDiraction;
        _shipControls.MoveCameraDelta += UpdateRotateDiraction;
        _shipControls.BarrelRotation += UpdateBarrelRotation;
    }

    private void OnDisable()
    {
        _shipControls.MoveCharacter -= UpdateDiraction;
        _shipControls.MoveCameraDelta -= UpdateRotateDiraction;
        _shipControls.BarrelRotation -= UpdateBarrelRotation;
    }

}