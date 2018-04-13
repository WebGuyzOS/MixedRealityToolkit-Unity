﻿// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using MixedRealityToolkit.InputModule.InputSources;
using UnityEngine;
using UnityEngine.EventSystems;

namespace MixedRealityToolkit.InputModule.EventData
{
    public class DictationEventData : BaseInputEventData
    {
        /// <summary>
        /// String result of the current dictation.
        /// </summary>
        public string DictationResult { get; private set; }

        /// <summary>
        /// Audio Clip of the last Dictation recording Session.
        /// </summary>
        public AudioClip DictationAudioClip { get; private set; }

        public DictationEventData(EventSystem eventSystem) : base(eventSystem) { }

        public void Initialize(IInputSource inputSource, string dictationResult, AudioClip dictationAudioClip = null, object[] tags = null)
        {
            BaseInitialize(inputSource, tags);
            DictationResult = dictationResult;
            DictationAudioClip = dictationAudioClip;
        }
    }
}
