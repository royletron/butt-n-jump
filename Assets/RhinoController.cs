using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;
using UnityStandardAssets._2D;

[RequireComponent(typeof (PlatformerCharacter2D))]
public class RhinoController : MonoBehaviour
{
	public float speed = 1.0f;
	private PlatformerCharacter2D m_Character;
	private bool m_Jump;
	
	
	private void Awake()
	{
		m_Character = GetComponent<PlatformerCharacter2D>();
	}
	
	
	private void Update()
	{
		if (!m_Jump)
		{
			// Read the jump input in Update so button presses aren't missed.
			m_Jump = CrossPlatformInputManager.GetButtonDown("Jump");
			print (m_Jump);
		}
	}
	
	
	private void FixedUpdate()
	{
		// Read the inputs.
//		bool crouch = Input.GetKey(KeyCode.LeftControl);
//		float h = speed
		// Pass all parameters to the character control script.
		m_Character.Move(speed, false, m_Jump);
		m_Jump = false;
	}
}
