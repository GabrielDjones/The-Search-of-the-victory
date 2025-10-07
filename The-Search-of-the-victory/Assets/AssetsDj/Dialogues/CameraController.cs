using UnityEngine;

public class CameraController2D : MonoBehaviour
{
    public Transform target;       // O objeto que a c�mera vai seguir (ex: Player)
    public float smoothSpeed = 0.125f;
    public Vector3 offset;         // Ajuste manual da posi��o da c�mera em rela��o ao jogador

    private float fixedY;          // Altura fixa da c�mera
    private Quaternion fixedRotation;

    void Start()
    {
        // Guarda o Y inicial e a rota��o da c�mera
        fixedY = transform.position.y;
        fixedRotation = transform.rotation;
    }

    void LateUpdate()
    {
        if (target == null) return;

        // Calcula posi��o desejada apenas no eixo X
        Vector3 desiredPosition = new Vector3(target.position.x + offset.x, fixedY, transform.position.z + offset.z);
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);

        transform.position = smoothedPosition;

        // Mant�m rota��o original (sem girar)
        transform.rotation = fixedRotation;
    }
}
