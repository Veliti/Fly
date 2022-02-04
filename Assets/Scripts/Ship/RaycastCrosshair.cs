using UnityEngine;

[RequireComponent(typeof(RectTransform))]
public class RaycastCrosshair : MonoBehaviour
{
    [SerializeField] GameObject _raycastFrom;
    [SerializeField] float _raycastDistance = 50f;
    [SerializeField, Range(0f, 1f)] float _minCrosshairSize;

    private RectTransform _tranform;
    private Vector3 _forward = new Vector3(1, 0, 0);

    private void UpdateCrosshair()
    {
        var target = GetTarget();
        var screenPoint = Camera.main.WorldToScreenPoint(target);
        _tranform.anchoredPosition = screenPoint;
        var scale = (1 - screenPoint.z / _raycastDistance) * (1 - _minCrosshairSize) + _minCrosshairSize;
        _tranform.localScale = Vector3.one * scale;
    }

    private Vector3 GetTarget()
    {
        var ray = new Ray(_raycastFrom.transform.position, _raycastFrom.transform.rotation * _forward);
        if(Physics.Raycast(ray, out RaycastHit hit, _raycastDistance))
        {
            return hit.point;
        }
        else
        {
            return _raycastFrom.transform.position + _raycastFrom.transform.rotation *_forward * _raycastDistance;
        }
    }

    private void Awake() => _tranform = GetComponent<RectTransform>();

    private void Update()
    {
        UpdateCrosshair();
    }
}
