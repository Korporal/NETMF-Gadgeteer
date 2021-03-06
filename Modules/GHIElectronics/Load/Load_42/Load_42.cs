﻿using GT = Gadgeteer;
using GTM = Gadgeteer.Modules;
using GTI = Gadgeteer.Interfaces;

namespace Gadgeteer.Modules.GHIElectronics
{
    // -- CHANGE FOR MICRO FRAMEWORK 4.2 --
    // If you want to use Serial, SPI, or DaisyLink (which includes GTI.SoftwareI2C), you must do a few more steps
    // since these have been moved to separate assemblies for NETMF 4.2 (to reduce the minimum memory footprint of Gadgeteer)
    // 1) add a reference to the assembly (named Gadgeteer.[interfacename])
    // 2) in GadgeteerHardware.xml, uncomment the lines under <Assemblies> so that end user apps using this module also add a reference.

    /// <summary>
    /// A module that has seven 3Amp 50V digital switches for Microsoft .NET Gadgeteer.
    /// </summary>
    /// <example>
    /// <para>The following example uses a <see cref="Load"/> object to toggle pins on the module. 
    /// These outputs could control high current loads, such as relays, motors, solenoids, or high current LEDs. 
    /// </para>
    /// <code>
    /// using System;
    /// using System.Collections;
    /// using System.Threading;
    /// using Microsoft.SPOT;
    /// using Microsoft.SPOT.Presentation;
    /// using Microsoft.SPOT.Presentation.Controls;
    /// using Microsoft.SPOT.Presentation.Media;
    /// using Microsoft.SPOT.Touch;
    ///
    /// using Gadgeteer.Networking;
    /// using GT = Gadgeteer;
    /// using GTM = Gadgeteer.Modules;
    /// using Gadgeteer.Modules.GHIElectronics;
    ///
    /// namespace TestApp
    /// {
    ///     public partial class Program
    ///     {
    ///         void ProgramStarted()
    ///         {
    ///             // Turn the first pin off.
    ///             load.P1.Write(false);
    ///
    ///             // Read the current state of the third pin
    ///             bool bOn = load.P3.Read();
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public class Load : GTM.Module
    {
        /// <summary>
        /// Pin 1 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P1;

        /// <summary>
        /// Pin 2 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P2;

        /// <summary>
        /// Pin 3 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P3;

        /// <summary>
        /// Pin 4 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P4;

        /// <summary>
        /// Pin 5 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P5;

        /// <summary>
        /// Pin 6 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P6;

        /// <summary>
        /// Pin 7 on the module.
        /// </summary>
        public GT.Interfaces.DigitalOutput P7;

        // Note: A constructor summary is auto-generated by the doc builder.
        /// <summary></summary>
        /// <param name="socketNumber">The socket that this module is plugged in to.</param>
        public Load(int socketNumber)
        {
            // This finds the Socket instance from the user-specified socket number.  
            // This will generate user-friendly error messages if the socket is invalid.
            // If there is more than one socket on this module, then instead of "null" for the last parameter, 
            // put text that identifies the socket to the user (e.g. "S" if there is a socket type S)
            Socket socket = Socket.GetSocket(socketNumber, true, this, null);
            socket.EnsureTypeIsSupported('Y', this);

            P1 = new GTI.DigitalOutput(socket, Socket.Pin.Three, false, this);
            P2 = new GTI.DigitalOutput(socket, Socket.Pin.Four, false, this);
            P3 = new GTI.DigitalOutput(socket, Socket.Pin.Five, false, this);
            P4 = new GTI.DigitalOutput(socket, Socket.Pin.Six, false, this);
            P5 = new GTI.DigitalOutput(socket, Socket.Pin.Seven, false, this);
            P6 = new GTI.DigitalOutput(socket, Socket.Pin.Eight, false, this);
            P7 = new GTI.DigitalOutput(socket, Socket.Pin.Nine, false, this);
        }
    }
}