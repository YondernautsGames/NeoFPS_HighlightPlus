using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HighlightPlus;

namespace NeoFPS
{
    [HelpURL("https://docs.neofps.com/manual/interactionref-mb-interactiveobjectcornermarkers.html")]
	[RequireComponent (typeof (InteractiveObject))]
	public class InteractiveObjectHighlightPlus : MonoBehaviour
	{
        [SerializeField, Tooltip("The highlight effects to show.")]
		private HighlightEffect[] m_HighlightEffects = null;

        private InteractiveObject m_Interactable = null;

		void OnValidate ()
		{
			if (m_HighlightEffects == null || m_HighlightEffects.Length == 0)
                m_HighlightEffects = GetComponentsInChildren<HighlightEffect>();
		}

		void Start ()
		{
			m_Interactable = GetComponent <InteractiveObject> ();
			m_Interactable.onCursorEnter += Show;
			m_Interactable.onCursorExit += Hide;
			
			Hide ();
		}

		public void Show ()
		{
			for (int i = 0; i < m_HighlightEffects.Length; ++i)
			{
				if (m_HighlightEffects[i] != null)
					m_HighlightEffects[i].SetHighlighted(true);
			}
		}

		public void Hide ()
		{
			for (int i = 0; i < m_HighlightEffects.Length; ++i)
			{
				if (m_HighlightEffects[i] != null)
					m_HighlightEffects[i].SetHighlighted(false);
			}
		}
	}
}