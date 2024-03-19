using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramixManager : MonoBehaviour
{
    public GameObject tetrahedronPrefab;
    public GameObject[] vetTetrahedron = new GameObject[24];

    void Start()
    {
        for (int i = 0; i < 24; i++)
        {
            if (i == 0)
            {
                vetTetrahedron[i] = Instantiate(tetrahedronPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            }
            else
                vetTetrahedron[i] = Instantiate(tetrahedronPrefab, new Vector3(vetTetrahedron[i - 1].transform.position.x + 1, 0, 0), vetTetrahedron[i - 1].transform.rotation);
        }

        vetTetrahedron[0].transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);

        vetTetrahedron[1].transform.SetPositionAndRotation(new Vector3(vetTetrahedron[0].transform.position.x + 1, 0, 0), vetTetrahedron[0].transform.rotation);

        vetTetrahedron[2].transform.SetPositionAndRotation(new Vector3(.5f, .864f, .29f), Quaternion.Euler(new Vector3(37f, 0f, -180f)));

        vetTetrahedron[3].transform.SetPositionAndRotation(new Vector3(0.5f, 0.86603f, 0.28868f), Quaternion.identity);

        vetTetrahedron[4].transform.SetPositionAndRotation(new Vector3(1.5f, .864f, .29f), Quaternion.Euler(new Vector3(37f, 0f, -180f)));
    }

    private void ChangeRotationAndRotation(GameObject gameObject, Vector3 newPosition, Vector3 newRotation)
    {
        gameObject.transform.position = newPosition;
        gameObject.transform.rotation = Quaternion.Euler(newRotation);
    }
}
