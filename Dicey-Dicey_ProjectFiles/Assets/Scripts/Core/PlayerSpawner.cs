using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace RPG.Core
{
    public class PlayerSpawner : MonoBehaviour
    {
        [SerializeField] List<GameObject> playerPreFabs;

        [SerializeField] Vector3 centre;
        [SerializeField] float radius;

        private void Start()
        {
            SpawnPlayersAroundCentre(playerPreFabs, centre, radius);
        }

        public void SpawnPlayersAroundCentre(List<GameObject> players, Vector3 point, float radius)
        {
            int playerCount = players.Count;

            for (int i = 0; i < playerCount; i++)
            {
                //Distance around the circle
                var radians = 2 * Mathf.PI / playerCount * i;

                //Get the vector direction
                var vertical = Mathf.Sin(radians);
                var horizontal = Mathf.Cos(radians);

                var spawnDir = new Vector3(horizontal, 0, vertical);

                //Get the spawn position
                var spawnPos = point + spawnDir * radius;

                //Spawn
                var player = Instantiate(players[i], spawnPos, Quaternion.identity) as GameObject;

                //Rotate the player to face the centre
                player.transform.LookAt(point);

                //Adjust height
                player.transform.Translate(new Vector3(0, player.transform.localScale.y / 2, 0));
            }
        }
    }
}

