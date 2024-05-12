using UnityEngine;

public class Goal : MonoBehaviour
{
    [Tooltip("Which player will get point when this goal being triggered.")]
    [SerializeField]
    private PlayerEnum playerEnum = PlayerEnum.None;

    public PlayerEnum PlayerEnum
    {
        get { return playerEnum; }
    }
}
