using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Sensor : MonoBehaviour
{
    [SerializeField] private BoxCollider boxCollider;
    [SerializeField] private Transform[] _detectedTetras;
    [SerializeField] private LayerMask _tetraLayerMask;

    public void SetParent()
    {
        _detectedTetras = GetAllTetras();

        foreach (var tetra in _detectedTetras)
        {
            tetra.transform.parent = transform;
        }
    }

    public void RemoveParent()
    {
        foreach (var tetra in _detectedTetras)
        {
            tetra.transform.parent = null;
        }
    }

    public void RotateRight()
    {
        SetParent();
        transform.Rotate(0, 120f, 0, Space.Self);
    }

    public void RotateLeft()
    {
        SetParent();
        transform.Rotate(0, -120f, 0, Space.Self);
    }

    private Transform[] GetAllTetras()
    {
        // Parâmetros para o boxcast
        Vector3 center = transform.position + boxCollider.center;
        Vector3 halfExtents = boxCollider.size / 2f;
        Quaternion orientation = transform.rotation;

        // Encontra todos os objetos que colidem com o boxcast
        Collider[] detectedTetras = Physics.OverlapBox(center, halfExtents, orientation, _tetraLayerMask);
        List<Transform> afaga = new List<Transform>();
        foreach (Collider collider in detectedTetras)
        {
            afaga.Add(collider.transform.parent);
            // Faça o que quiser com o collider colidido, por exemplo:
            Debug.Log("Objeto colidido: " + collider.name);
        }
        return afaga.ToArray();
    }
}
