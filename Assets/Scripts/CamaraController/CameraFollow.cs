using UnityEngine;
using Cinemachine;

public class CameraFollow : MonoBehaviour
{
    public GameObject target; // Objeto al que la cámara debe seguir
    private CinemachineVirtualCamera virtualCamera; // Referencia al componente CinemachineVirtualCamera

    private void Start()
    {
        virtualCamera = GetComponent<CinemachineVirtualCamera>();
    }

    private void LateUpdate()
    {
        if (target != null)
        {
            // Actualizar la posición de seguimiento de la cámara para que coincida con la posición del objetivo
            virtualCamera.Follow = target.transform;
        }
    }
}

