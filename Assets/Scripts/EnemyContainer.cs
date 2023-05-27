using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class EnemyContainer : MonoBehaviour
{
    private PoolMono<Enemy> _enemyPool;
    private static EnemyContainer _instance;
    [SerializeField] private Player _player;
    [SerializeField] private float _distanceToEnableEnemy;
    [SerializeField] private Enemy[] _enemys;
    void Start()
    {
        if (_instance != null)
        {
            Destroy(gameObject);
            return;
        }
        _instance = this;
        _enemys = GetComponentsInChildren<Enemy>();
    }
    public void CreateBloodSpot(Vector2 position)
    {
        var bloodSpot = _enemyPool.GetFreeElement();
        bloodSpot.transform.position = position;
    }
    public static EnemyContainer GetInstance()
    {
        return _instance;
    }
    private void OnDrawGizmos()
    {
        if (_player)
        {
            Gizmos.DrawLine(_player.transform.position, new Vector2(_player.transform.position.x + _distanceToEnableEnemy, _player.transform.position.y));
        }
    }
}
