using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _mainCharacter;
    [SerializeField] private float _dy;
    [SerializeField] private float _dx;
    [SerializeField] private float _smooth;
    [SerializeField] private float _maxLeftBoardX;
    [SerializeField] private float _maxUpBoardY;
    [SerializeField] private float _maxRightBoardX;
    public bool isFollowForPlayer = true;
    private void Awake()
    {
        this.transform.position = new Vector3(0,0,-10);
    }

    private void Update()
    {
        if (isFollowForPlayer)
        {
            Vector3 target = new Vector3()
            {
                x = transform.position.x,
                y = transform.position.y,
                z = transform.position.z,
            };
            if (_mainCharacter.position.x > _maxLeftBoardX && _mainCharacter.position.x < _maxRightBoardX)
            {
                target.x = _mainCharacter.position.x - _dx;
            }
            Vector3 pos = Vector3.Lerp(transform.position, target, _smooth * Time.deltaTime);
            transform.position = pos;
        }
    }

}
