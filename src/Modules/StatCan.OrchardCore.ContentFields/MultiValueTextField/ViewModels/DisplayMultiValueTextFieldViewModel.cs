﻿using OrchardCore.ContentManagement;
using OrchardCore.ContentManagement.Metadata.Models;

namespace StatCan.OrchardCore.ContentFields.MultiValueTextField.ViewModels
{
    public class DisplayMultiValueTextFieldViewModel
    {
        public string[] Values => Field.Values;
        public Fields.MultiValueTextField Field { get; set; }
        public ContentPart Part { get; set; }
        public ContentPartFieldDefinition PartFieldDefinition { get; set; }
    }
}



