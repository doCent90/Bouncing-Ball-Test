using UnityEngine;
using IJunior.TypedScenes;

public class StartGame : MonoBehaviour
{
    public void OpenGameScene()
    {
        Game.Load();
    }
}
