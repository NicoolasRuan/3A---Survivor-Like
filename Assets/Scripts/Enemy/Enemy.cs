using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject playerObj; // criar uma var do player
    private Rigidbody2D rb; // o rigidbody do inimigo
    public float enemySpeed; // velocidade do inimigo

    private void Start()
    {
        playerObj = GameObject.FindGameObjectWithTag("Player");
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // pegando a posição do player
        Vector3 playerPosition = playerObj.transform.position;
        rb.MovePosition(Vector3.MoveTowards(transform.position, playerPosition, enemySpeed * Time.fixedDeltaTime));
    }


}
