﻿using OrchardCore.ContentManagement.Metadata.Models;
using OrchardCore.ContentTypes.Editors;
using OrchardCore.DisplayManagement.Views;
using System.Threading.Tasks;

namespace StatCan.OrchardCore.ContentFields.MultiValueTextField.Settings
{
    public class MultiValueTextFieldSettingsDriver : ContentPartFieldDefinitionDisplayDriver<Fields.MultiValueTextField>
    {
        public override IDisplayResult Edit(ContentPartFieldDefinition partFieldDefinition)
        {
            return Initialize<MultiValueTextFieldSettings>("MultiValueTextFieldSettings_Edit", model => partFieldDefinition.PopulateSettings(model))
                .Location("Content");
        }

        public override async Task<IDisplayResult> UpdateAsync(ContentPartFieldDefinition partFieldDefinition, UpdatePartFieldEditorContext context)
        {
            var model = new MultiValueTextFieldSettings();

            await context.Updater.TryUpdateModelAsync(model, Prefix);

            context.Builder.WithSettings(model);

            return Edit(partFieldDefinition);
        }
    }
}



