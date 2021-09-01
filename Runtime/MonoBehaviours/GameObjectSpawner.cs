using System.Collections.Generic;
using UnityEngine;

namespace Bones
{
    public class GameObjectSpawner : MonoBehaviour
    {
        [SerializeField] private GameObject _display;
        
        [SerializeField] private int _objectsToSpawnCount;

        private GameObject _prefabToSpawn;

        private void Awake()
        {
            HideDisplay();
        }

        private void HideDisplay()
        {
            _display.SetActive(false);
        }
        
        public void SetPrefabToSpawn(GameObject prefab)
        {
            _prefabToSpawn = prefab;
        }

        public void SpawnObjects(List<GameObject> objectsToSpawn = null)
        {
            if (objectsToSpawn != null)
            {
                foreach (GameObject go in objectsToSpawn)
                {
                    Instantiate(go, transform.position + Random.insideUnitSphere * 10f, Quaternion.identity);
                }

                return;
            }
            
            // TODO
            for (int i = 0; i < _objectsToSpawnCount; i++)
            {
                Instantiate(_prefabToSpawn);
            }
        }
    }
}