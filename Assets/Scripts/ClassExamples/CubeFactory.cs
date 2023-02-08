using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFactory : MonoBehaviour
{
    [SerializeField] private GameObject cubePrefab;
    [SerializeField] private int offset = 0;
    // Start is called before the first frame update
    void Start()
    {
        CreateCubes();
    }

    void CreateCubes()
    {
        for (int x = 0; x < 25; x += 5)
        {
            for (int y = 10; y < 35; y += 5)
            {
                for (int z = 0; z < 25; z += 5)
                {
                    // add code to instantiate prefabs here
                     GameObject newObj = Instantiate(cubePrefab);
                    newObj.transform.position = new Vector3(x + offset, y + offset, z + offset);
                    newObj.transform.rotation = Quaternion.identity;
                }
            }
        }
    }

}
