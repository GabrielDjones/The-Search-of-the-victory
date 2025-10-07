using UnityEngine;

public class CameraController2D : MonoBehaviour
{
    public Transform target;       // O objeto que a câmera vai seguir (ex: Player)
    public float smoothSpeed = 0.125f;
    public Vector3 offset;         // Ajuste manual da posição da câmera em relação ao jogador

    private float fixedY;          // Altura fixa da câmera
    private Quaternion fixedRotation;

    void Start()
    {
        // Guarda o Y inicial e a rotação da câmera
        fixedY = transform.position.y;
        fixedRotation = transform.rotation;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Calcula posição desejada apenas no eixo X
        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, fixedY, transform.position.z + offset.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        // Mantém rotação original (sem girar)
        transform.rotation = fixedRotation;
    }
}
