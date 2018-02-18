﻿using FluentTerminal.Models;
using FluentTerminal.Models.Enums;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace FluentTerminal.App.Views
{
    public interface ITerminalView
    {
        event EventHandler<TerminalSize> TerminalSizeChanged;
        event EventHandler<string> TerminalTitleChanged;
        event EventHandler<Command> KeyboardCommandReceived;

        Task ChangeTheme(TerminalColors theme);
        Task ChangeOptions(TerminalOptions options);
        Task<TerminalSize> CreateTerminal(TerminalOptions options, TerminalColors theme, IEnumerable<KeyBinding> keyBindings);
        Task ConnectToSocket(string url);
        void Close();
        Task FocusTerminal();
        Task<string> GetSelection();
        Task Write(string text);
    }
}