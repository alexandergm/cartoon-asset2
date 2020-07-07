using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorCar : MonoBehaviour
{
    [SerializeField] private MeshRenderer _kuzov;
    [SerializeField] private Material _okMaterial;
    [SerializeField] private Material _failMaterial;
    [SerializeField] private float _timeColoring = 1f;
    private Material _currentMaterial;
    
    public void Ok()
    {
        _currentMaterial = _kuzov.material;
        _kuzov.material = _okMaterial;
        Invoke(nameof(ReturnMaterial), _timeColoring);
    }
    
    public void Fail()
    {
        _currentMaterial = _kuzov.material;
        _kuzov.material = _failMaterial;
        Invoke(nameof(ReturnMaterial), _timeColoring);
    }

    private void ReturnMaterial()
    {
        _kuzov.material = _currentMaterial;
    }
    
}
