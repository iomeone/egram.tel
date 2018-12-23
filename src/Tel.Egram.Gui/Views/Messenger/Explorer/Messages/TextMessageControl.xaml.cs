﻿using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Tel.Egram.Components.Messenger.Explorer.Messages;
using Tel.Egram.Components.Messenger.Explorer.Messages.Basic;

namespace Tel.Egram.Gui.Views.Messenger.Explorer.Messages
{
    public class TextMessageControl : BaseControl<TextMessageModel>
    {
        public TextMessageControl()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
