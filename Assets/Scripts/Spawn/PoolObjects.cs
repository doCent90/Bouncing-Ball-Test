using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class PoolObjects : MonoBehaviour
{
    [SerializeField] private GameObject[] _template;

    private List<GameObject> _pool = new List<GameObject>();

    private const int Capacity = 4;

    protected void Initialize()
    {
        for (int i = 0; i < Capacity; i++)
        {
            int randomNumber = Random.Range(0, _template.Length - 1);
            var spawned = Instantiate(_template[randomNumber], transform.position, Quaternion.identity);
            spawned.SetActive(false);
            _pool.Add(spawned);
        }
    }

    protected bool TryGetObject(out GameObject gameObject)
    {
        gameObject = _pool.First(p => p.activeSelf == false);

        return gameObject != null;
    }
}
