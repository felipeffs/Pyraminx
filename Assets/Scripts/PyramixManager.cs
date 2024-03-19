using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PyramixManager : MonoBehaviour
{
    public GameObject tetrahedronPrefab;
    public TetraCreator[] vetTetrahedron = new TetraCreator[24];

    void Start()
    {
        Assemble();
    }

    private void Assemble()
    {
        for (int i = 0; i < 24; i++)
        {
            if (i == 0)
            {
                vetTetrahedron[i] = Instantiate(tetrahedronPrefab, new Vector3(0, 0, 0), Quaternion.identity).GetComponent<TetraCreator>().Build("Tetra #" + i);
            }
            else
                vetTetrahedron[i] = Instantiate(tetrahedronPrefab, new Vector3(vetTetrahedron[i - 1].transform.position.x + 1, 0, 0), vetTetrahedron[i - 1].transform.rotation).GetComponent<TetraCreator>().Build("Tetra #" + i);
        }

        // Fileira inferior
        vetTetrahedron[0].transform.SetPositionAndRotation(new Vector3(0, 0, 0), Quaternion.identity);
        vetTetrahedron[1].transform.SetPositionAndRotation(new Vector3(1f, 0, 0), Quaternion.identity);
        vetTetrahedron[2].transform.SetPositionAndRotation(new Vector3(2f, 0, 0), Quaternion.identity);

        //Fileira Inferior (invertidos)
        vetTetrahedron[3].transform.SetPositionAndRotation(new Vector3(.5f, .865f, .29f), Quaternion.Euler(new Vector3(37f, 0f, -180f)));
        vetTetrahedron[4].transform.SetPositionAndRotation(new Vector3(1.5f, .865f, .29f), Quaternion.Euler(new Vector3(37f, 0f, -180f)));

        // Topo
        vetTetrahedron[5].transform.SetPositionAndRotation(new Vector3(.5f, .86603f, .29f), Quaternion.identity);
        vetTetrahedron[10].transform.SetPositionAndRotation(new Vector3(1.5f, .86603f, .29f), Quaternion.identity);


        // Lateral Esquerda

        // Fileira inferior
        vetTetrahedron[7].transform.SetPositionAndRotation(new Vector3(.5f, 0f, .866025f), Quaternion.Euler(new Vector3(0, 0, 0)));

        // Fileira Inferior invertida
        vetTetrahedron[6].transform.SetPositionAndRotation(new Vector3(.254f, .865f, .722f), Quaternion.Euler(new Vector3(-180f, 30f, 36.995f)));
        var tetra6Transform = vetTetrahedron[6].GetTetra().transform;
        tetra6Transform.localPosition = new Vector3(0, 0, -.5f);
        tetra6Transform.localRotation = Quaternion.Euler(new Vector3(0, -30f, 0));

        //Lateral Direita
        vetTetrahedron[8].transform.SetPositionAndRotation(new Vector3(1.5f, 0f, .866025f), Quaternion.Euler(new Vector3(0, 0, 0)));
        vetTetrahedron[9].transform.SetPositionAndRotation(new Vector3(1, 0f, 1.73205f), Quaternion.Euler(new Vector3(0, 0, 0)));

        //
        vetTetrahedron[11].transform.SetPositionAndRotation(new Vector3(1f, .86603f, 1.156025f), Quaternion.identity);
        vetTetrahedron[12].transform.SetPositionAndRotation(new Vector3(1f, 1.73206f, .578f), Quaternion.identity);

        vetTetrahedron[13].transform.SetPositionAndRotation(new Vector3(.753f, .865f, 1.587f), Quaternion.Euler(new Vector3(-180, 30, 36.995f)));
        var tetra13Transform = vetTetrahedron[13].GetTetra().transform;
        tetra13Transform.localPosition = new Vector3(0, 0, -.5f);
        tetra13Transform.localRotation = Quaternion.Euler(new Vector3(0, -30f, 0));

        vetTetrahedron[14].transform.SetPositionAndRotation(new Vector3(.757f, 1.729f, 1.01f), Quaternion.Euler(new Vector3(-180, 30, 36.995f)));
        var tetra14Transform = vetTetrahedron[14].GetTetra().transform;
        tetra14Transform.localPosition = new Vector3(0, 0, -.5f);
        tetra14Transform.localRotation = Quaternion.Euler(new Vector3(0, -30f, 0));

        vetTetrahedron[15].transform.SetPositionAndRotation(new Vector3(1f, 1.731f, .581f), Quaternion.Euler(new Vector3(37f, 0f, -180f)));

        vetTetrahedron[16].transform.SetPositionAndRotation(new Vector3(1.744f, .865f, .73f), Quaternion.Euler(new Vector3(180, -30, -36.995f)));
        var tetra16Transform = vetTetrahedron[16].GetTetra().transform;
        tetra16Transform.localPosition = new Vector3(-.866025f, 0, .011f);
        tetra16Transform.localRotation = Quaternion.Euler(new Vector3(0, 30f, 0));

    }

    private void ChangeRotationAndRotation(GameObject gameObject, Vector3 newPosition)
    {
        ChangeRotationAndRotation(gameObject, newPosition, Vector3.zero);
    }

    private void ChangeRotationAndRotation(GameObject gameObject, Vector3 newPosition, Vector3 newRotation)
    {
        gameObject.transform.position = newPosition;
        gameObject.transform.rotation = Quaternion.Euler(newRotation);
    }
}
