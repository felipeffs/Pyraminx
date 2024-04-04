using UnityEngine;

public class ObjectRotatorWithMouse : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 10f;

    void Update()
    {
        if (Input.GetMouseButton(1)) // Botão direito do mouse para girar
        {
            float mouseX = Input.GetAxis("Mouse X") * rotationSpeed;
            float mouseY = Input.GetAxis("Mouse Y") * rotationSpeed;

            // Calcular o vetor de movimento do mouse na tela (horizontalmente)
            Vector3 mouseMovementX = new Vector3(0, mouseX, 0);

            // Calcular o vetor de movimento do mouse na tela (verticalmente)
            Vector3 mouseMovementY = new Vector3(mouseY, 0, 0);

            // Transformar os vetores de movimento do mouse para o espaço da câmera
            mouseMovementX = Camera.main.transform.TransformDirection(mouseMovementX);
            mouseMovementY = Camera.main.transform.TransformDirection(mouseMovementY);

            // Girar o objeto em torno do eixo horizontal da câmera
            transform.Rotate(mouseMovementX, Space.World);

            // Girar o objeto em torno do eixo vertical da câmera
            transform.Rotate(mouseMovementY, Space.World);
        }
    }
}


// using UnityEngine;

// public class ObjectRotatorWithMouse : MonoBehaviour
// {
//     private float _sceneWidth;
//     private float _sceneHeight;

//     private Vector3 _pressPoint;
//     private Quaternion _startRotation;
//     [SerializeField] private bool swE;

//     void Start()
//     {
//         _sceneWidth = Screen.width;
//         _sceneHeight = Screen.height;
//     }

//     void Update()
//     {
//         if (Input.GetKeyDown(KeyCode.Q)) swE = !swE;

//         if (Input.GetMouseButtonDown(1))
//         {
//             _pressPoint = Input.mousePosition;
//             _startRotation = transform.rotation;
//         }
//         else if (Input.GetMouseButton(1))
//         {
//             if (swE)
//             {
//                 float currentDistanceBetweenMousePositions = (Input.mousePosition - _pressPoint).x;
//                 transform.rotation = _startRotation * Quaternion.Euler(Vector3.forward * (currentDistanceBetweenMousePositions / _sceneWidth) * 360);
//             }
//             else
//             {
//                 float currentDistanceBetweenMousePositions = (Input.mousePosition - _pressPoint).x;
//                 transform.rotation = _startRotation * Quaternion.Euler(Vector3.up * (currentDistanceBetweenMousePositions / _sceneHeight) * 360);
//             }
//         }
//     }
// }
