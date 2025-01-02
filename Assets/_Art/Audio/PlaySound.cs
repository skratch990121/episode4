using UnityEngine;
public class PlaySound : MonoBehaviour
{
public void Play(AudioClip clip)
{ AudioSource.PlayClipAtPoint(clip, transform.position); }
}