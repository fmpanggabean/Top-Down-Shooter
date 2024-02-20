using UnityEngine;

public class GameManager : Singleton
{
    private SpawnController spawnController;

    new private void Awake()
    {
        base.Awake();

        spawnController = FindObjectOfType<SpawnController>();
    }

    private void Start()
    {
        spawnController.Spawn("Player", 1, 0, transform);
    }
}
