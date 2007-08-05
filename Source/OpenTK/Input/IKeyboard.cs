﻿#region --- License ---
/* Copyright (c) 2007 Stefanos Apostolopoulos
 * See license.txt for license info
 */
#endregion

namespace OpenTK.Input
{
    public interface IKeyboard : IInputDevice
    {
        bool this[Key k] { get; }
        int NumberOfKeys { get; }
        int NumberOfFunctionKeys { get; }
        int NumberOfLeds { get; }
        long DeviceID { get; }
    }
}