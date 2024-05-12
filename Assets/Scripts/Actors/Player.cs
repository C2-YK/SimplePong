using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField]
    private PlayerEnum playerEnum = PlayerEnum.None;

    private Rigidbody2D rb;
    private Vector2 initialPosition;
    private float playerSpeed;

    public PlayerEnum PlayerEnum
    {
        get { return playerEnum; }
    }

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initialPosition = transform.position;
        playerSpeed = GameInstance.instance.playerSpeed;
    }

    public void ResetPosition()
    {
        transform.position = initialPosition;
    }

    public void MoveUp()
    {
        rb.velocity = new Vector2(0, playerSpeed);
    }

    public void MoveDown()
    {
        rb.velocity = new Vector2(0, -playerSpeed);
    }

    public void MoveStop()
    {
        rb.velocity = Vector2.zero;
    }
}
