using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoMoveObject : MonoBehaviour
{
    [SerializeField] private float rotateSpeed = 0.0f;
    [SerializeField] private float direction = 1f;

    private float _rotateValue = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        _rotateValue = 0.0f;
    }

    private void OnEnable()
    {
        _rotateValue = 0.0f;
    }

    private void OnDisable()
    {
        _rotateValue = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 0f, Time.deltaTime * _rotateValue * direction);
    }

    public void SetDirection(bool _dir)
    {
        Debug.Log("Set Direction:  " + _dir);
        this.direction = _dir ? 1f : -1f;
        _rotateValue = this.rotateSpeed;
    }

    public void StopRotate()
    {
        Debug.Log("Stop Rotation!");
        _rotateValue = 0.0f;
    }
}
