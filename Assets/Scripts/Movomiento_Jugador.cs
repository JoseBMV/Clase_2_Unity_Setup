using UnityEngine;

/// <summary>
/// Controla el movimiento básico del jugador sin usar físicas (Rigidbody)
/// </summary>
public class Movomiento_Jugador : MonoBehaviour
{
    [Tooltip("Velocidad de movimiento del jugador")]
    public float speed = 5f; // Velocidad del movimiento del jugador

    void Update()
    {
        // Obtener los ejes de entrada
        // GetAxis devuelve un valor entre -1 y 1 según la tecla presionada
        float horizontalInput = Input.GetAxis("Horizontal"); // A/D o Flechas izquierda/derecha
        float verticalInput = Input.GetAxis("Vertical");     // W/S o Flechas arriba/abajo

        // Calcular la dirección del movimiento
        // Creamos un vector 3D donde:
        // X = movimiento horizontal
        // Y = 0 (no hay movimiento vertical)
        // Z = movimiento hacia adelante/atrás
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);
        
        // Normalizar el vector de movimiento para evitar mayor velocidad en diagonal
        // Multiplicamos por la velocidad y Time.deltaTime para un movimiento suave
        movement = movement.normalized * speed * Time.deltaTime;
        
        // Aplicar el movimiento al transform del objeto
        // Translate mueve el objeto en la dirección especificada
        transform.Translate(movement);
    }
}
