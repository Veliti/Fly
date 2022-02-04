using System.Collections.Generic;
using UnityEngine;

public class Pool<T> where T : Component
{
    private Queue<T> _pool;
    private T _poolObject;
    private Transform _parent;

    public T GetObject()
    {
        if(_pool.Count != 0)
        {
            var queueObject = _pool.Dequeue();
            queueObject.gameObject.SetActive(true);
            return queueObject;
        }
        else
        {
            return Object.Instantiate<T>(_poolObject, _parent);
        }
    }

    public void StoreObject(T objectToStore)
    {
        objectToStore.gameObject.SetActive(false);
        _pool.Enqueue(objectToStore);
    }

    public Pool(T poolObject, Transform parent)
    {
        _poolObject = poolObject;
        _parent = parent;
        _pool = new Queue<T>();
    }

    ~Pool()
    {
        foreach (var item in _pool)
        {
            Object.Destroy(item);
        }
    }
}