/*
 * Copyright 2020 Yondernauts Games Ltd
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *     http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

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