﻿using EarTrumpet_Actions.DataModel.Actions;

namespace EarTrumpet_Actions.ViewModel.Actions
{
    class SetVariableActionViewModel : PartViewModel
    {
        public OptionViewModel Option { get; }
        public TextViewModel Text { get; }

        public SetVariableActionViewModel(SetVariableAction action) : base(action)
        {
            Option = new OptionViewModel(action, nameof(action.Value));
            Text = new TextViewModel(action);

            Attach(Option);
            Attach(Text);
        }
    }
}
