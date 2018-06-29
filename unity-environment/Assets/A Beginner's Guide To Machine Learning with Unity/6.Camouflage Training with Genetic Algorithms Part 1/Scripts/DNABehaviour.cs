using UnityEngine;

public class DnaBehaviour : MonoBehaviour {
	
	//they will impart there color onto the next generation
	//gene for colour
	//you also want to store for each person whether or not they have been clicked
	//set this to true after you click on them
	//when they die we will store how long they lived for
	[SerializeField] private SpriteRenderer m_sRenderer;
	[SerializeField] private Collider2D m_sCollider;
	public float TimeToDie = 0;
	private bool m_dead = false;
	public Color ColorGene;

}
