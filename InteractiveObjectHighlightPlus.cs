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
		private HighlightEffect m_HighlightEffect = null;

        private InteractiveObject m_Interactable = null;

		void OnValidate ()
		{
			if (m_HighlightEffect == null)
                m_HighlightEffect = GetComponentInChildren<HighlightEffect>();
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
            if (m_HighlightEffect != null)
                m_HighlightEffect.SetHighlighted(true);
        }

		public void Hide ()
        {
            if (m_HighlightEffect != null)
                m_HighlightEffect.SetHighlighted(false);
        }
	}
}